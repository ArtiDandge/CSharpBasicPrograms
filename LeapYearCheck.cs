using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class LeapYearCheck
    {
        public static void LeapYear()
        {
            Console.WriteLine("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine(year + " is leap year");
            }
            else
            {
                Console.WriteLine(year + " is not leap year");
            }

        }
    }
}
