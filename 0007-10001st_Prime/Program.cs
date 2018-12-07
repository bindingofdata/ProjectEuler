using System;

namespace _0007_10001st_Prime
{
    class Program
	{
		static void Main(string[] args)
		{
			/*
			 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
			 * What is the 10 001st prime number?
			 */

			int nthPrime = 0;
			int currentPrime = 0;
			int workingNumber = 2;

			Console.WriteLine("Find the nth Prime number!");
			Console.WriteLine();
			Console.Write("Which Prime number would you like to find? ");
			nthPrime = Int32.Parse(Console.ReadLine());

			while (currentPrime < nthPrime)
			{
				if (IsPrimeNumber(workingNumber))
				{
					currentPrime += 1;
					if (currentPrime == nthPrime)
					{
						Console.WriteLine("Prime number {0} is {1}", nthPrime, workingNumber);
						break;
					}
				}
				workingNumber += 1;
			}



			Console.ReadLine();
		}

		static public bool IsPrimeNumber(long number)
		{
			if (number % 2 == 0)
			{
				if (number == 2)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else if (number % 3 == 0)
			{
				if (number == 3)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else if (number % 5 == 0)
			{
				if (number == 5)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				for (long j = 7; j < number / 2; j++)
				{
					if (number % j == 0)
					{
						if (number == j)
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

			return true;
		}// end isPrimeNumber()
	}
}
