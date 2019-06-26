using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using StaticClasses;

namespace _0010_Summation_of_Primes
{
	internal static class Program
	{
		private static void Main(string[] args)
		{
			Stopwatch calculationTime = new Stopwatch();

			Console.WriteLine("Add all the Prime numbers below the specified number.");
			Console.WriteLine();
			Console.Write("What number would you like to go up to? ");
			/*
			 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
			 * 
			 * Find the sum of all the primes below two million (2000000).
			 */

			// max number to check up to and var to hold the sum
			int maxTestNumber = int.Parse(Console.ReadLine());
			calculationTime.Start();
			SumPrimesWithList( maxTestNumber );
			SumPrimesWithArray( maxTestNumber );
			SumPrimesWithHelperClass( maxTestNumber );
			calculationTime.Stop();
			Console.WriteLine( calculationTime.Elapsed );

			Console.ReadLine();
		}// end Main()

		static public void SumPrimesWithArray( int number )
		{
			int sumOfPrimes = 0;
			int numberOfPrimes = 0;
			bool[] primeArray = new bool[number];

			for (int testInt = 2; testInt < primeArray.Length; testInt++ )
			{
				if ( !primeArray[testInt] )
				{
					sumOfPrimes += testInt;
					numberOfPrimes++;
					// mark all multiples of testInt as true so they skipped when encountered
					for (int i = testInt; i < primeArray.Length; i+=testInt )
					{
						primeArray[i] = true;
					}
				}
			}

			Console.WriteLine( "There are {0} Prime numbers below {1}.", numberOfPrimes, number );
			Console.WriteLine( "The sum of the Prime numbers is {0}", sumOfPrimes );
		}

		static public void SumPrimesWithHelperClass( int number )
		{
            int[] primes = Primes.GetPrimes( number );
            int sumOfPrimes = 0;

			foreach (int prime in primes )
			{
				sumOfPrimes += prime;
			}

			Console.WriteLine( "There are {0} Prime numbers below {1}.", primes.Length, number );
			Console.WriteLine( "The sum of the Prime numbers is {0}", sumOfPrimes );
		}

		static public void SumPrimesWithList( int number )
		{
			// list to hold primes
			List<int> primeNumbers = new List<int>();
			int sumOfPrimes = 0;
			// add 2 as a prime to the list as it will always be present and is the only even prime
			primeNumbers.Add( 2 );

			// we only need to test odd numbers, so we don't even loop through even ones.
			for (int i = 3; i <= number; i += 2 )
			{
				if ( IsPrimeNumber( i, primeNumbers ) )
				{
					primeNumbers.Add( i );
					//Console.WriteLine( "Added " + i + " to the list of Primes" );
				}
			}

			foreach (int prime in primeNumbers )
			{
				sumOfPrimes += prime;
			}

			Console.WriteLine( "There are {0} Prime numbers below {1}.", primeNumbers.Count, number );
			Console.WriteLine( "The sum of the Prime numbers is {0}", sumOfPrimes );
		}

		static public bool IsPrimeNumber(int number, List<int> primeNumbers)
		{
			// This takes ~9 minutes and 14 seconds to run.
			//for ( long j = 3; j < number / 2; j += 2 )
			//{
			//	if ( number % j == 0 )
			//	{
			//		if ( number == j )
			//		{
			//			return true;
			//		}
			//		else
			//		{
			//			return false;
			//		}
			//	}
			//}

			// This takes ~2 minutes and 4 seconds to run.
			foreach (int pastPrime in primeNumbers )
			{
				if ( number % pastPrime == 0 )
				{
					return false;
				}
			}

			return true;
		}// end isPrimeNumber()
	}
}
