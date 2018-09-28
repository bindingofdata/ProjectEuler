using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

			Console.WriteLine("Sum of all multiples of two numbers!");
			Console.WriteLine("------------------------------------");
			Console.WriteLine();
			Console.Write("Enter your first number: ");
			int firstNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			Console.Write("Enter your second number: ");
			int secondNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			for (int i = 0; i < 1000; i++)
			{
				// Check for multiples of first and second number.
				if (i % firstNumber == 0)
				{
					multiples.Add(i);
					Console.WriteLine("Multiple of {0} found: {1}", firstNumber, i);
				}
				else if (i % secondNumber == 0)
				{
					multiples.Add(i);
					Console.WriteLine("Multiple of {0} found: {1}", secondNumber, i);
				}
			}

			foreach (int number in multiples)
			{
				sum += number;
			}

			Console.WriteLine("The sum of all multiples is {0}", sum);
			Console.ReadLine();
		}
	}
}
