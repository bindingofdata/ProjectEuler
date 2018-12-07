using System;

namespace _0005_Smallest_Multiple
{
    class Program
	{
		static void Main(string[] args)
		{
			/*
			 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
			 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
			 */
			const int MAX = 2147483647;

			Console.WriteLine("Calculate the smallest positive number that is divisible by all numbers between 1 and x.");
			Console.WriteLine();
			Console.Write("What number would you like to use for 'x'? ");
			int maxFactor = Int32.Parse(Console.ReadLine());

			for (int i = maxFactor * 2; i < MAX; i+= maxFactor)
			{
				if (IsSmallestCommonFactor(maxFactor, i))
				{
					Console.WriteLine("The smallest common factor of all numbers below {0} is {1}", maxFactor, i);
					break;
				}
			}

			Console.ReadLine();
		}

		public static bool IsSmallestCommonFactor(int maxFactor, int currentNumber)
		{
			for (int i = 2; i <= maxFactor; i++)
			{
				if (currentNumber % i != 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
