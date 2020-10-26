using System;
using System.Collections.Generic;
using System.Text;

namespace LabsYN
{
    class Operators1
    {

        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            //Key sequence: 3817283 or 3827183
            // Declare 7 int variables for the input numbers and other variables
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
            At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
            a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
            You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please,  type numbers by step ");

            //int input = Convert.ToInt32(Console.ReadLine());
            //int result1 = 3817283;
            //int result2 = 3827183;


            //if (input == result1 || input == result2)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    //
            //    Console.WriteLine("Great job!!!");
            //}

            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Something went wrong");
            //}
            int f1 = 3;
            int f2 = 8;
            int f3 = 2;
            int f4 = 1;
            int f5 = 7;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Enter first step and press buton");
            int a = Convert.ToInt32(Console.ReadLine());
            if (f1 == a)
            {
                Console.WriteLine("Good");
                int b = Convert.ToInt32(Console.ReadLine());
                if (f2 == b)
                {
                    Console.WriteLine("Nice");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (f3 == c | f4 == c)
                    {
                        Console.WriteLine("Few more steps");
                        int d = Convert.ToInt32(Console.ReadLine());
                        if (f5 == d)
                        {
                            Console.WriteLine("Almost home");
                            int e = Convert.ToInt32(Console.ReadLine());
                            if (f4 == e | f3 == e)
                            {
                                Console.WriteLine("Pre-last");
                                int f = Convert.ToInt32(Console.ReadLine());
                                if (f2 == f)
                                {
                                    Console.WriteLine("The last one");
                                    int g = Convert.ToInt32(Console.ReadLine());
                                    if (f1 == g)
                                    {
                                        Console.WriteLine("Great job!!!");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong carry");

            }
            // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing

        }
        #endregion

        #region calculator
        static void Calculator()
        {

            // Set Console.ForegroundColor  value
            Console.WriteLine(@"Select the arithmetic operation:
                        1. Multiplication 
                        2. Divide 
                        3. Addition 
                        4. Subtraction
                        5. Exponentiation ");


            // Implement option input (1,2,3,4,5)
            int mlt = 1;
            int div = 2;
            int add = 3;
            int sub = 4;
            int exp = 5;

            int sgn = Convert.ToInt32(Console.ReadLine());
            if (sgn == 1)
            {
                Console.WriteLine("Input first value");
                try
                {
                    int v1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input second value");
                    int v2 = Convert.ToInt32(Console.ReadLine());
                    int result = v1 * v2;
                    Console.WriteLine(v1 + " * " + v2 + " = " + result);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("FormatException", ex);
                }



            }
            else if (sgn == 2)
            {
                Console.WriteLine("Input first value");
                int v1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input second value");

                try
                {
                    int v2 = Convert.ToInt32(Console.ReadLine());
                    int result = v1 / v2;
                    Console.WriteLine(v1 + " / " + v2 + " = " + result);
                }
                catch (DivideByZeroException e)
                {

                    Console.WriteLine("Second value is 0", e);
                    throw new DivideByZeroException();
                    Calculator();
                }
            }
            else if (sgn == 3)
            {
                Console.WriteLine("Input first value");
                int v1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input second value");
                int v2 = Convert.ToInt32(Console.ReadLine());
                int result = v1 + v2;
                Console.WriteLine(v1 + "+" + v2 + "=" + result);
            }
            else if (sgn == 4)
            {
                Console.WriteLine("Input first value");
                int v1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input subtracted value");
                int v2 = Convert.ToInt32(Console.ReadLine());
                int result = v1 - v2;
                Console.WriteLine(v1 + "-" + v2 + "=" + result);
            }
            else if (sgn == 5)
            {
                Console.WriteLine("Input first value");
                int v1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input second value");
                int v2 = Convert.ToInt32(Console.ReadLine());
                var result = Math.Pow(v1, v2);
                Console.WriteLine(v1 + " *" + v2 + "=" + result);

            }

            //     and input of  two or one numbers
            //  Perform calculations and output the result 

        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            // Implement input of the number

            int i, fact = 1, number;
            Console.Write("Enter any Number: ");

            // Implement input the for circle to calculate factorial of the number

            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }

            // Output the result

            Console.Write("Factorial of " + number + " is: " + fact);
        }

        #endregion

    }
}
