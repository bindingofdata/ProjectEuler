using System;

namespace _0006_Sum_Square_Difference
{
    class Program
	{
		static void Main(string[] args)
		{
			/*
			 * The sum of the squares of the first ten natural numbers is,
			 * 1^2 + 2^2 + ... + 10^2 = 385
			 * 
			 * The square of the sum of the first ten natural numbers is,
			 * (1 + 2 + ... + 10)^2 = 55^2 = 3025
			 * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
			 * 
			 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
			 */
			int maxNumber = 0;
			int sumOfSquareTotal = 0;
			int squareOfSumTotal = 0;
			int difference = 0;

			Console.WriteLine("Find the difference between the sum of the squares and the square of the sum of a range of Natural Numbers!");
			Console.WriteLine("Natural Numbers range from 1 to the number of your choice!");
			Console.WriteLine();
			Console.Write("Enter the maximum Natural Number you want to use: ");
			maxNumber = Int32.Parse(Console.ReadLine());

			sumOfSquareTotal = SumOfSquares(maxNumber);
			squareOfSumTotal = SquareOfSum(maxNumber);
			difference = squareOfSumTotal - sumOfSquareTotal;

			Console.WriteLine();
			Console.WriteLine("The sum of the squares of Natural Numbers from 1 to {0} is {1}", maxNumber, sumOfSquareTotal);
			Console.WriteLine("The square of the sum of Natural numbers from 1 to {0} is {1}", maxNumber, squareOfSumTotal);
			Console.WriteLine("The difference between the sum of the squares and the square of the sum is {0}", difference);

			Console.ReadLine();
		}

		public static int SumOfSquares(int maxInt)
		{
			int total = 0;
			for (int i = 1; i <= maxInt; i++)
			{
				total += i * i;
			}

			return total;
		}

		public static int SquareOfSum(int maxInt)
		{
			int total = 0;
			for (int i = 1; i <= maxInt; i++)
			{
				total += i;
			}

			return total * total;
		}
	}
}
