using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class GuessTheNumber
    {
        public static void GuessNumber()
        {
            while (true)
            {
                int randno = RandomNumGenerator(1, 11);
                int partNumber = Convert.ToInt32(randno / 2); 
                int guessAttempts = 1;
                while (true)
                {
                    Console.Write("Enter a number between 1 and 100(0 to quit):");
                    int yourGuess = Convert.ToInt32(Console.ReadLine());
                    if (yourGuess != randno)
                    {
                        if (yourGuess < partNumber)
                        {
                            Console.WriteLine("Please try guessing number in multiple of " + partNumber);
                        }
                        else 
                        {
                            Console.WriteLine("Please try guessing number in multiple of " + partNumber);
                        }
                    }
                    if (yourGuess == 0)
                    {
                        Console.WriteLine("try entering number other than 0");
                        return;
                    }
                    else if (yourGuess < randno)
                    {
                        Console.WriteLine("Your guess is very low, try again by entering number higher than" + yourGuess);
                        guessAttempts++;
                        continue;
                    }
                    else if (yourGuess > randno)
                    {
                        Console.WriteLine("Your guess is very High, try again by entering number lower than" + yourGuess);
                        guessAttempts++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You guessed it! The number was " + randno);
                        Console.WriteLine("You guessed the correct numner in " + guessAttempts + " attempts");

                        Environment.Exit(0);
                    }
                }
            }
        }
        static int RandomNumGenerator(int lower, int upper) {
            Random random = new Random();
            return random.Next(lower, upper);
        }
    }
}
