using System;
using System.Collections.Generic;
using System.Text;

namespace NASAproj
{
    // StopEvents are objects that contain the necessary data from a stop event.
    class StopEvent
    {
        int timestamp;
        int eventcodeid;
        int param;

        // Constructors
        public StopEvent(string stpevent)
        {
            char[] del = { ' ', ',', '.', ':', '\t' };
            string[] stop = stpevent.Split(del);

            setEvtTime(Int32.Parse(stop[1]), Int32.Parse(stop[2]), Int32.Parse(stop[3]));
            eventcodeid = Convert.ToInt32(stop[4]);
            param = Convert.ToInt32(stop[5]);
        }
        public StopEvent(string time, string eventC, string par)
        {
            setEvtTime(Convert.ToInt32(time.Substring(0, 2)), Convert.ToInt32(time.Substring(3, 2)), Convert.ToInt32(time.Substring(6)));
            eventcodeid = Convert.ToInt32(eventC);
            param = Convert.ToInt32(par);
        }


        // format 01:07.8
        public void setEvtTime(int hour, int min, int mili)
        {
            timestamp = hour *1000 + min *10  + mili;
        }

        int getTime()
        {
            return timestamp;
        }

        public string toString()
        {
            return timestamp.ToString() + "," + eventcodeid.ToString() + "," + param.ToString();
        }

        public int getCode()
        {
            return eventcodeid;
        }
    }

    /*
    class StopTest
    {
        static void Main(string[] args)
        {
            string evt = "327707,01:21.5,82,20";
            StopEvent evnt1 = new StopEvent(evt);
            Console.WriteLine(evnt1.toString());

            string time = "01:21.5";
            string code = "82";
            string param = "20";
            StopEvent evnt2 = new StopEvent(time, code, param);
            Console.WriteLine(evnt2.toString());
        }
    }*/
}
