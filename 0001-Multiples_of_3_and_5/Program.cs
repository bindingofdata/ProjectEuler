using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _0001_Multiples_of_3_and_5
{
    class Program
	{
		static void Main(string[] args)
		{
			/*
			 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
			 * The sum of these multiples is 23.
			 * Find the sum of all the multiples of 3 or 5 below 1000.
			 */

			List<int> multiples = new List<int>();
			int sum = 0;
            Stopwatch timer = new Stopwatch();

			Console.WriteLine("Sum of all multiples of two numbers!");
			Console.WriteLine("------------------------------------");
			Console.WriteLine();
			Console.Write("Enter your first number: ");
			int firstNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			Console.Write("Enter your second number: ");
			int secondNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

            timer.Start();
            /*
            // This is my original implementation. 
            // It's pretty fast (~0.000442s for 3 and 5)
            for (int i = 0; i < 1000; i++)
			{
				// Check for multiples of first and second number.
				if (i % firstNumber == 0)
				{
					multiples.Add(i);
					//Console.WriteLine("Multiple of {0} found: {1}", firstNumber, i);
				}
				else if (i % secondNumber == 0)
				{
					multiples.Add(i);
					//Console.WriteLine("Multiple of {0} found: {1}", secondNumber, i);
				}
			}

			foreach (int number in multiples)
			{
				sum += number;
			}
            */
            
            // This is an updated implementation based on the Sieve of Eratosthenes
            // It's really fast (0.0000102s)
            bool[] multiplesOfThree = new bool[1001];
            bool[] multiplesOfFive = new bool[1001];

            for (int i = 3; i < multiplesOfThree.Length; i += 3)
                multiplesOfThree[i] = true;

            for (int i = 5; i < multiplesOfFive.Length; i += 5)
                multiplesOfFive[i] = true;

            for (int i = 1; i < 1001; i++)
                if (multiplesOfFive[i] || multiplesOfThree[i])
                    sum += i;
            
            timer.Stop();

			Console.WriteLine("The sum of all multiples is {0}", sum);
            Console.WriteLine($"Calculated in {timer.Elapsed}");
			Console.ReadLine();
		}
	}
}
