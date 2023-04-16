using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RentaDeAutos.Class
{
    class HourAndDateClass
    {
        private DateTime dateTime;
        private int hour;
        private int minute;

        public HourAndDateClass()
        {
            this.dateTime = DateTime.Today;
            hour = 0;
            minute = 0;
        }

        public int Hour
        {
            get
            {
                return dateTime.Hour;
            }           
        }

        public int Minute
        {
            get
            {
                return dateTime.Minute;
            }
        }

        public DateTime DateTime { get => dateTime; set => dateTime = value; }

        public string GetDate()
        {     
            return dateTime.ToString();
        }
        public void UpdateDateTime(DateRangeEventArgs e)
        {          
            dateTime = e.Start.Date;
            dateTime = dateTime.AddMinutes(minute);
            dateTime = dateTime.AddHours(hour);
        }

        public void updateHour(int newHour)
        {
            dateTime = dateTime.AddHours(newHour);
            hour += newHour;
        }

        public void UpdateMinute(int newMinute)
        {
            dateTime = dateTime.AddMinutes(newMinute);
            minute += newMinute;
        }

    }
}
