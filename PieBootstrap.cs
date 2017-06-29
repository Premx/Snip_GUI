using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snip_GUI
{
    class PieBootstrap
    {

        SortableBindingList<Line> data;
        public PieBootstrap(SortableBindingList<Line> data)
        {
            
            this.data = data;
            ThreadStart thStart = new ThreadStart(this.start);
            Thread thParse = new Thread(thStart);
            thParse.Start();
            start();
        }

        private void start()
        {
          
            Dictionary<String, int> dic = new Dictionary<string, int>();
            foreach (Line l in data)
            {
                if(l.browser == "" || l.browser == null || l.browser.Length < 3)
                {
                    continue;
                }
                if (dic.ContainsKey(l.browser))
                {
                    dic[l.browser]++;
                }
                else
                {
                    dic.Add(l.browser,1);
                }
            }
            Tuple<String, float>[] tupledata = new Tuple<String, float>[dic.Count];
            int i = 0;

            int t = 0;

            foreach (int i2 in dic.Values)
            {
                t += i2;
            }
           

            foreach (String s in dic.Keys)
            {
                float val = dic[s];
                tupledata[i] = Tuple.Create(s,val*100/t);

                i++;
            }

            


            ChartView cv = new ChartView(tupledata);
            cv.Visible = true;
            cv.Enabled = true;
        }
    }
}
