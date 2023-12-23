using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05.Models
{
    public class MyDate
    {
        public MyDate(int year, int month, int day, int hour, int minute)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.minute = minute;
        }
        public MyDate(int year, int month, int day, int hour)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
        }
        public MyDate(MyDate myDate) : this(myDate.year, myDate.month, myDate.day, myDate.hour, myDate.minute) { }
        public MyDate() { }

        protected int year;
        protected int month;
        protected int day;
        protected int hour;
        protected int minute;


    }
}
