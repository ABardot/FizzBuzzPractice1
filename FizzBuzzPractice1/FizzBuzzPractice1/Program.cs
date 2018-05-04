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

            //for (int i = 0; i < 100; i++) // Divisible by 100
            //{
            //    if (i % 15 == 1) // Started at 1 instead of 0 because 0 will always spell FizzBuzz
            //    {
            //        Console.WriteLine("Fizz Buzz");
            //    }
            //    else if (i % 5 == 1)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else if (i % 3 == 1)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //} 

            // 3 - Fizz
            // 7 - Buzz
            // 21 - FizzBuzz

            for (int i = 1; i < 100; i++) // Fizz Buzz without int only strings
            {
                var outOut = "";

                if (i % 3 == 1) { outOut += "Fizz"; }
                if (i % 7 == 1) { outOut += "Buzz"; }
                if (i % 15 == 1) { outOut += "Fizz Buzz"; }

                Console.WriteLine(outOut);

            }

        } // Main end
    }
}
