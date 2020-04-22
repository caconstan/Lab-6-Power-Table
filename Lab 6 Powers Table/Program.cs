using System;

namespace Lab_6_Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!\n");

            do
            {
                int userInteger = ReadIntegers("Enter an integer: ");

                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("======\t=======\t=====");

                for (int i=1; i <= userInteger; i++)
                {
                    Console.WriteLine($"{Math.Pow(i, 1)}\t{Math.Pow(i, 2)}\t{Math.Pow(i, 3)}");
                }
            } while (RunAgain());
        }
        static int ReadIntegers(string prompt)
        {
            try
            {
                Console.WriteLine(prompt);
                return int.Parse(Console.ReadLine().Trim());
            }
            catch (Exception myEX)
            {
                Console.WriteLine("I'm sorry, I didn't understand.");
                return ReadIntegers(prompt);
            }
        }

        static bool RunAgain()
        {
            Console.WriteLine("Continue? (y/n)");
            string response = Console.ReadLine().Trim();
            if (response == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
