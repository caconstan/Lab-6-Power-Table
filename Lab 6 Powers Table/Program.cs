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

                Console.WriteLine("{0,-10}\t{1,-10}\t{2,-10}", "Number", "Squared", "Cubed");
                Console.WriteLine("{0,-10}\t{1,-10}\t{2,-10}", "======", "=======", "=====");

                for (int i=1; i <= userInteger; i++)
                {
                    Console.WriteLine("{0,-10}\t{1,-10}\t{2,-10}", Math.Pow(i, 1), Math.Pow(i, 2), Math.Pow(i, 3));
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
