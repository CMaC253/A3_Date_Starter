
using System;
// if you want to use the instructor's version of "MyDate":
//using Date_SOLUTION; // leave this line UNcommented
using A3_Date_StudentWork;

///
/// Colin McDonald 
/// Bit 142 Fall quarter
/// Cascadia College, Professor Mike Panitz
/// Assignment 02, Birthday calculator.
/// 

namespace A3_Date
{
    class Birthday
    {
        static void Main(string[] args)
        {
            int todayMonth;
            int todayDay;
            //This section will initialize the values that will become the parameters for
            //The today and bday objects..
            //Oh yeah, the total day's passed will initialize here as: total, 
            int bdayMonth;
            int bdayDay;
            //You'll see why total has to be equal in a moment...
            //Okay, it's because nothing gives total an actual value, so we have to make it literal
            //Where today and bday will be defined before incrementing, total is purely used at an increment.
            int total=0;


            //The program will ask the user for today's and bday's month and day.
            Console.WriteLine("What is today's month?");
            Int32.TryParse(Console.ReadLine(), out todayMonth);
            Console.WriteLine("What is today's day?");
            Int32.TryParse(Console.ReadLine(), out todayDay);
            Console.WriteLine("What is your birthday month?");
            Int32.TryParse(Console.ReadLine(), out bdayMonth);
            Console.WriteLine("What is your birthday day?");
            Int32.TryParse(Console.ReadLine(), out bdayDay);

            //The program now initialized two MyDate classes bday and today
            //It will use the values entered by the user, as the parameters
            //for the two instances.
            MyDate bday = new MyDate(bdayMonth, bdayDay);
            MyDate today = new MyDate(todayMonth, todayDay);

            //Here the console will print the total days in the month attached to bday.
            //Then tell the user what month that is in
            Console.WriteLine("There are {0} days in month #{1}", bday.daysInMonth(), bdayMonth);


            //There will be a check to see if today's month and day match with bdays month and day
            //If it is, then user gets a happy birthday message.
            //If not then while today does not equal bday, today will evoke the next day method
            //The next day will check to see if the day is at it's max for the given slot in the array
            //If it is not then it will increment until it is true then move on to the next month.
            //This will continue until the day before the birthday, giving us the total days until user's birthday.
            if (today.equals(bday))
                Console.WriteLine("Happy birthday!");
            else if (!today.equals(bday))
            {
                while (!today.equals(bday))
                {
                    today.nextDay();
                    total++;
                 }

            }
            //Finally we print the number of days until the birthday in string form
            //Then the total is finally displayed.
            Console.WriteLine("Number of days until {0}: {1}", bday.toString(), total);
        }
    }

}




