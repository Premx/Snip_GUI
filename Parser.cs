using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;

namespace Snip_GUI
{
    class Parser
    {
        private int keymode { get; set; }

        public static List<int> httpcode = new List<int>();
       
        List<SortableBindingList<Line>> ListofLinelist;
        List<Dictionary<String, int>[]> ListofCache;


        DateTime t1, t2;

        private int currentline = 0;
        private int totalline = 0;

        int INDEXip = 1;
        int INDEXdate = 4;
        int INDEXrequest = 5;
        int INDEXhttpcode = 6;
        int INDEXtraffic = 7;
        int INDEXagent = 10;

        //Theadcontorler
        int threadcontrolI = 0;
        private void controlwatch()
        {
            threadcontrolI = 0;
            while (threadcontrolI != threads)
            {
                Thread.Sleep(500);
                Progressbar(currentline, totalline);

            }
            Progressbar(totalline, totalline);

            SortableBindingList<Line> exportlist = new SortableBindingList<Line>();
            Dictionary<String, int>[] exportcache = new Dictionary<String, int>[6];

            UpdateStatus("Pass Processing...");
            foreach (SortableBindingList<Line> templ in ListofLinelist)
            {
                foreach(Line l in templ)
                {
                   
                    exportlist.Add(l);
                }
            }

            //List<Dictionary<String, int>[]>
            foreach(Dictionary<String, int>[] tempcache in ListofCache)
            {
                if(tempcache[0] == null && tempcache[5] == null)
                {
                    continue;
                }
                int i = 0;
                foreach (Dictionary<String,int> tempdic in tempcache){
                    if (exportcache[i] == null)
                    {
                        exportcache[i] = new Dictionary<string, int>();
                    }

                    foreach(String key in tempdic.Keys)
                    {
                        if (exportcache[i].ContainsKey(key))
                        {
                            exportcache[i][key] += tempdic[key];
                        }
                        else
                        {
                            exportcache[i].Add(key, tempdic[key]);
                        }
                        
                    }
                    
                    i++;
                }
            }
            t2 = DateTime.Now;
            UpdateStatus(exportlist.Count + "Entries\t" + (t2-t1).TotalSeconds + "s");

            form1instance.setGridDataView(exportlist,exportcache);

            //UpdateStatus(String.Format("Complete: {0} Entries", linelist.Count));
        }

        private void registerlinelist(SortableBindingList<Line> ltemp, int threadid)
        {
            ListofLinelist.Add(ltemp);
        }

        private void registercachelist(Dictionary<String,int>[] dic)
        {
            ListofCache.Add(dic);
        }

        private int threads;

        const String datePattern = "dd/MMM/yyyy:HH:mm:ss";

        private static Parser instance;

        private Parser() { }


        public static Parser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Parser();
                }
                return instance;
            }
        }

        public static void setRegex(params String[] pattern)
        {
            logEntryPattern = "";
            foreach (String s in pattern)
            {
                logEntryPattern += s;
            }
        }
        const String regex1 = "^([\\d.]+)"; // Client IP
        const String regex2 = " (\\S+)"; // -
        const String regex3 = " (\\S+)"; // -
        const String regex4 = " \\[([\\w:/]+\\s[+\\-]\\d{4})\\]"; // Date
        const String regex5 = " \"(.+?)\""; // request method and url
        const String regex6 = " (\\d{3})"; // HTTP code
        const String regex7 = " (\\d+|(.+?))"; // Number of bytes
        const String regex8 = " \"([^\"]+|(.+?))\""; // Referer
        const String regex9 = " \"([^\"]+|(.+?))\""; // Agent

        private static String logEntryPattern = regex1 + regex2 + regex3 + regex4 + regex5 + regex6 + regex7 + regex8 + regex9;


        //Extract Browser Data from Agent
        const String browserPattern = ".+?[/\\s][\\d.]+";



        //Every 100 line update progress bar
        public int progressbarPara = 10000;

        private String[] keys;
        private bool useKeys = false;

        public static String logfileName;

        //Multithreading control
        public void start(String[] keys, int keymode, int threads)
        {
            this.threads = threads;
            t1 = DateTime.Now;
            currentline = 0;
            ListofLinelist = new List<SortableBindingList<Line>>();
            ListofCache = new List<Dictionary<string, int>[]>();

            this.keymode = keymode;
            if (keys.Length > 0)
                useKeys = true;
            this.keys = keys;


            Console.WriteLine(logfileName);

            System.IO.StreamReader sr = openfile(logfileName);

            totalline = File.ReadLines(logfileName).Count();


            List<Thread> threadslist = new List<Thread>();

            Thread THthreadcontrol = new Thread(() => controlwatch());
            THthreadcontrol.Start();


            for (int i = 0; i < threads; i++)
            {

                

                Thread thParse = new Thread(() => parse(totalline, sr,i));

                Console.WriteLine("Preparing Thread#{0}...", thParse.ManagedThreadId);

                thParse.Start();
            }



            UpdateStatus("Parsing \"" + logfileName + "\"...");

            //Cache

        }


       


        private String readStreamLine(StreamReader sr)
        {
            lock (sr)
            {
                if (sr.BaseStream == null || sr.EndOfStream)
                {
                    sr.Close();
                    return null;
                }
                String line = sr.ReadLine();
               
                if (line == null)
                {
                    Console.WriteLine("L:" + currentline);

                    line = "";
                }

                currentline++;
                return line;
            }
        }

        private void parse(int totalline, StreamReader sr,int threadid)
        {

            Console.WriteLine("Thread {0} started!", Thread.CurrentThread.ManagedThreadId);

            String line = "";

            SortableBindingList<Line> linelist = new SortableBindingList<Line>();
            Dictionary<String, int>[] cache = new Dictionary<string, int>[6];


            while ((line = readStreamLine(sr)) != null)
            {
                Match regexMatch = Regex.Match(line, logEntryPattern);
               
                if(regexMatch.Groups.Count < 10)
                {
                    return;
                }

                //Progressbar
                //if ((currentLine % progressbarPara) == 0)
                //{
                //    Progressbar(currentLine, tillLine, Thread.CurrentThread.ToString());
                //}

                //using keys from listbox1
                if (useKeys)
                {
                    bool foundsomething = false;
                    bool exit = false;
                    foreach (String key in keys)
                    {
                        if (line.Contains(key))
                        {
                            //|| or mode
                            //At least one key must be found
                            foundsomething = true;
                            if (keymode == 0)
                                break;
                        }
                        else
                        {

                            //&& and mode
                            //Every key must be found
                            if (keymode == 1)
                            {
                                exit = true;
                                break;
                            }
                        }

                    }
                    //go back
                    if ((!foundsomething) || exit)
                    {
                        continue;
                    }

                }


                //Extracting Data from Regex Match
                DateTime d = DateTime.MinValue ;
                try{
                    d = DateTime.ParseExact(regexMatch.Groups[INDEXdate].Value, (datePattern + " K"), System.Globalization.CultureInfo.InvariantCulture);
                }
                catch(System.FormatException e)
                {

                }
                    

                String hostname = getItem(regexMatch, INDEXip);

                String request = getItem(regexMatch, INDEXrequest);


                String trafficstr = getItem(regexMatch, INDEXtraffic);

                //Log Syntax traffic 0 = '-'
                if (trafficstr == "-")
                    trafficstr = "0";
                int traffic = int.Parse(trafficstr);


                String agent = getItem(regexMatch, INDEXagent);

                //Filter
                if (agent.Length > 3)
                {
                    if (agent.Substring(0, 3) == "\" \"")
                    {
                        agent = agent.Substring(3, agent.Length - 3);
                    }
                    if (agent[0] == '<')
                    {
                        agent = "";
                    }

                }

                Match mBrowser = Regex.Match(agent, browserPattern);
                String browser = "";
                if (mBrowser.Success && mBrowser.Groups[0].Value[0] != '<')
                    browser = mBrowser.Groups[0].Value;


                Line l = new Line(hostname, d, request, short.Parse(getItem(regexMatch, INDEXhttpcode)), traffic, browser);//,agent);
                linelist.Add(l);

                
                dicchecker(cache,0, hostname);
                dicchecker(cache,1, d.ToString());
                dicchecker(cache,2, request);
                dicchecker(cache,3, l.httpcode.ToString());
                dicchecker(cache,4, traffic.ToString());
                dicchecker(cache,5, browser);
                

                //dicchecker(cache, 6 , agent);



            }
            //Progressbar(tillLine, tillLine, Thread.CurrentThread.ToString());



            //form1instance.setGridDataView(linelist,cache);

            //UpdateStatus(String.Format("Complete: {0} Entries", linelist.Count));
            registerlinelist(linelist,threadid);
            registercachelist(cache);
            if(threads - threadcontrolI == 1)
            {
                t2 = DateTime.Now;
            }

            threadcontrolI++;
            Console.WriteLine("Thread {0} stopped!", threadid);

        }

        private static bool checkDateTime(DateTime dt1, DateTime dt2, DateTime dtcheck)
        {
            if (dt1.Ticks <= dtcheck.Ticks && dt2.Ticks >= dtcheck.Ticks)
            {
                return true;
            }
            return false;
        }

        private String getItem(Match match, int i)
        {
            return match.Groups[i].Value;
        }


        private List<int> gethttpcodes()
        {
            lock (httpcode)
            {
                return httpcode;
            }
        }

        private void Progressbar(int lineNumber, int maxlineNumber)
        {
           

            form1instance.setLabelProgresstext((lineNumber * 100 / maxlineNumber).ToString() + "%");

        }


        private void UpdateStatus(String text)
        {
            form1instance.setLabelStatustext(text);
        }



        public Form1 form1instance = null;

        private static System.IO.StreamReader openfile(String filename)
        {
            try
            {
                return new System.IO.StreamReader(filename);

            }
            catch (UnauthorizedAccessException e)
            {
                criticalError(e);
            }
            catch (FileNotFoundException e)
            {
                criticalError(e);
            }

            return null;

        }

        private static System.IO.StreamWriter writefile(String filename)
        {
            try
            {
                return new System.IO.StreamWriter(filename);
            }
            catch (UnauthorizedAccessException e)
            {
                criticalError(e);
            }
            return null;
        }


        private static void criticalError(Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(exception.Message);
            Environment.Exit(1);
        }


        private void dicchecker(Dictionary<String, int>[] cachedic, int index, String key)
        {
            Dictionary<String, int> tempdic = cachedic[index];
            if (tempdic == null)
            {
                cachedic[index] = new Dictionary<string, int>();
            }


            if (cachedic[index].ContainsKey(key))
            {
                if (key != String.Empty)
                    cachedic[index][key]++;
            }
            else
            {
                cachedic[index].Add(key, 1);
            }
        }

        private void addhttpcode(int code)
        {

        }


    }
}
