using System;

namespace A3_Date_StudentWork
{
    public class MyDate
    {
        private int day;
        private int[] daysPerMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int month;

        public MyDate(int m, int d)
        {
            month = m;
            day = d;
        }
        public MyDate()
        {

        }

        public int daysInMonth()
        {
            return daysPerMonth[month - 1];
        }

        public bool equals(MyDate d)
        {
            return ((month == d.month) && (day == d.day));
        }

        public int getDay()
        {
            return day;
        }

        public int getMonth()
        {
            return month;
        }

        public void nextDay()
        {
            if ((day + 1) > daysInMonth())
            {
                month = ((month+1)%12); 
                //In you're feeback on my first submission you said I needed to add 1 to the month first.
                //when i tried that the program crashed, but I put it back to this and it worked.
                day = 1;
            }
            else
            {
                day++;
            }
        }

        public void setDate(int m, int d)
        {
            month = m;
            day = d;
        }

        public string toString()
        {
            return (month + "/" + day);
        }
    }
}
