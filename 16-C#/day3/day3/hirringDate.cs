using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    public struct hirringDate
    {
        int year,day,month;

        public hirringDate(int _year, int _month, int _day)
        {
            year = _year;
            month = _month;
            day = _day;
        }
        public int Year
        {
            get 
            { return year; }
            set 
            { year = value; }

        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Day
        {
            get { return day; }
            set { day = value;}
        }


    }
}
