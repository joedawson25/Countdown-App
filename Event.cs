using System;
using System.Collections.Generic;
using System.Text;

namespace Countdown_App
{
    class Event
    {
        private string name;
        private string location;
        private DateTime date;
        private string time;
       
        public Event(string eventname, string eventlocation,
            DateTime eventdate,string eventtime)  
        {
            Name = eventname;
            Location = eventlocation;
            Date = eventdate;
            Time = eventtime;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if(value != null)
                {
                    name = value;
                }
            }
        }


        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                if (value != null)
                {
                    location = value;
                }
            }
        }

        public DateTime Date
        {

            get
            {
                return date;
            }

            set
            {
                if (value != null)
                {
                    date = value;
                }
            }
        }

        public string Time 
        {
            get
            {
                return time;
            }

            set
            {
                if (value != null)
                {
                    time = value;
                }
            }
        }

    }
}
