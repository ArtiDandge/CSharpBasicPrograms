using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class PowerOfNumber
    {
        public static void PowerFunction()
        {
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = Convert.ToInt32(Math.Pow(number, 2));
            Console.WriteLine("Squate of " + number + " is " + result);

        }
    }
}
