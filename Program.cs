using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C-Sharp basic program");
            Boolean test = true;
            do
            {
                Console.WriteLine("Choose option below");
                Console.WriteLine("1. Add two numbers");
                Console.WriteLine("2. Find Square");
                Console.WriteLine("3. Test Leap year or not");
                Console.WriteLine("4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Addition.Add();
                        break;
                    case 2:
                        PowerOfNumber.PowerFunction();
                        break;
                    case 3:
                        LeapYearCheck.LeapYear();
                        break;
                    case 4:
                        test = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter valid option only");
                        break;
                }
            } while (test != false);

        }
    }
}
