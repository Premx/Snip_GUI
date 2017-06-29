using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snip_GUI
{
    public class Line
    {
        public String hostname { get; }
        public DateTime date { get;  }
        public String request { get; }

        public short httpcode { get; }
        public int traffic { get; }
        public String browser { get; }
        //public String agent { get; }
        

        public Line(String hostname, DateTime date, String request, short code, int traffic,String browser) //,String agent)
        {
            
            this.hostname = hostname;
            this.date = date;
            this.request = request;
            this.httpcode = code;
            this.traffic = traffic;
            //this.agent = agent;
            this.browser = browser;
        }

       

    }
}
