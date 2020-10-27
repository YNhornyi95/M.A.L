using System;
using System.Collections.Generic;
using System.Text;

namespace LabsYN
{
    class Operators2
    {
        static void Main(string[] args)
        {
            //int res = 1, lim = 20;

            //for (int j = 1; j <= lim; ++j)
            //{
            //    res = j + 1;
            //    Console.WriteLine(j);
            //}

            //const int MyMax = 200;

            //Random random = new Random();
            // random.Next(MaxValue) returns a 32-bit signed integer that is greater than or equal to 0 and less than MaxValue
            //int Guess_number = random.Next(MyMax) + 1;
            // implement input of number and comparison result message in the while circle with  comparison condition
            int Guess_number = 0;
            Console.WriteLine("Let's play a game!");
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter your guess: ");
                Guess_number = Convert.ToInt32(Console.ReadLine());

                if (Guess_number >= 1 && Guess_number <= 54)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Too low!!!");
                }
                else if (Guess_number > 55)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Too high!!!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Guess_number + " is right! Congratulations.");
                }
            } while (Guess_number != 55);
        }
    }
}
