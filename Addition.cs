using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Addition
    {
        public static void Add()
        {
            Console.WriteLine("Enter first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result = number1 + number2;
            Console.WriteLine("Addition of two number " + result);
        }
    }
}
