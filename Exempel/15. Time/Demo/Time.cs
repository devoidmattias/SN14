using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Time
    {
        private int _day;
        private int _hour;
        private int _minute;
        private int _month;
        private int _year;

        // Egenskap (Property)
        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                _hour = value;
            }
        }

        
      
       
        public Time()
        {
            // tom
        }

        public Time(int hour, int minute)
        {
            Hour = hour;
            _minute = minute;
        }
    }
}
