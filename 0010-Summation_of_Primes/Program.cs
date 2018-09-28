using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using StaticClasses;

namespace _0010_Summation_of_Primes
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
			 * 
			 * Find the sum of all the primes below two million (2000000).
			 */
			
			
			// max number to check up to and var to hold the sum
			uint maxTestNumber = 0;
			
			Stopwatch calculationTime = new Stopwatch();

			Console.WriteLine("Add all the Prime numbers below the specified number.");
			Console.WriteLine();
			Console.Write("What number would you like to go up to? ");
			maxTestNumber = uint.Parse(Console.ReadLine());
			calculationTime.Start();
			//SumPrimesWithList( maxTestNumber );
			//SumPrimesWithArray( maxTestNumber );
			SumPrimesWithHelperClass( maxTestNumber );
			calculationTime.Stop();
			Console.WriteLine( calculationTime.Elapsed );

			Console.ReadLine();
		}// end Main()

		static public void SumPrimesWithArray( uint number )
		{
			uint sumOfPrimes = 0;
			uint numberOfPrimes = 0;
			bool[] primeArray = new bool[number];

			for ( uint testInt = 2; testInt < primeArray.Count(); testInt++ )
			{
				if ( !primeArray[testInt] )
				{
					sumOfPrimes += testInt;
					numberOfPrimes++;
					// mark all multiples of testInt as true so they skipped when encountered
					for ( uint i = testInt; i < primeArray.Count(); i+=testInt )
					{
						primeArray[i] = true;
					}
				}
			}


			Console.WriteLine( "There are {0} Prime numbers below {1}.", numberOfPrimes, number );
			Console.WriteLine( "The sum of the Prime numbers is {0}", sumOfPrimes );
		}

		static public void SumPrimesWithHelperClass( uint number )
		{
			uint[] primes = Primes.GetPrimes( number );
			uint sumOfPrimes = 0;

			foreach ( uint prime in primes )
			{
				sumOfPrimes += prime;
			}

			Console.WriteLine( "There are {0} Prime numbers below {1}.", primes.Length, number );
			Console.WriteLine( "The sum of the Prime numbers is {0}", sumOfPrimes );
		}

		static public void SumPrimesWithList( uint number )
		{
			// list to hold primes
			List<uint> primeNumbers = new List<uint>();
			uint sumOfPrimes = 0;
			uint lastPrime = 2;
			// add 2 as a prime to the list as it will always be present and is the only even prime
			primeNumbers.Add( 2 );

			// we only need to test odd numbers, so we don't even loop through even ones.
			for ( uint i = 3; i <= number; i += 2 )
			{
				if ( isPrimeNumber( i, primeNumbers ) )
				{
					primeNumbers.Add( i );
					//Console.WriteLine( "Added " + i + " to the list of Primes" );
					lastPrime = i;
				}
			}

			foreach ( uint prime in primeNumbers )
			{
				sumOfPrimes += prime;
			}

			Console.WriteLine( "There are {0} Prime numbers below {1}.", primeNumbers.Count, number );
			Console.WriteLine( "The sum of the Prime numbers is {0}", sumOfPrimes );

		}

		static public bool isPrimeNumber( uint number, List<uint> primeNumbers)
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
			foreach ( uint pastPrime in primeNumbers )
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
