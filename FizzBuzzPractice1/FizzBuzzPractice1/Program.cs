using System;


namespace FizzBuzzPractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 3 - Fizz
            // 5 - Buzz
            // 15 - FizzBuzz

            for (int i = 0; i < 100; i++) // Divisible by 100
            {
                if (i % 15 == 1) // Started at 1 instead of 0 because 0 will always spell FizzBuzz
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 1)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 1)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
