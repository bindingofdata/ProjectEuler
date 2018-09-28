using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StaticClasses;

namespace _0003_Largest_Prime_Factor
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 * The prime factors of 13195 are 5, 7, 13 and 29.
			 * What is the largest prime factor of the number 600851475143 ?
			 */

			Console.WriteLine("Find the Largest Prime factor of a number!");
			Console.WriteLine("------------------------------------------");
			Console.WriteLine();
			Console.Write("Enter the number you want the Largest Prime factor of: ");
			uint original = (uint)Convert.ToInt64(Console.ReadLine());
			uint factor = original;
			uint largest = 0;
			uint previousFactor = 0;

			// Store all primes up to half the supplied number
			uint[] primes = Primes.GetPrimes( original / 2 );

			// List to store all the prime factors of the supplied number
			List<ulong> primeFactors = new List<ulong>();

			foreach ( uint primeFactor in primeFactors)
			{
				if (primeFactor > largest)
				{
					largest = primeFactor;
				}
			}

			Console.WriteLine();
			Console.WriteLine("The largest factor of {0} is {1}.", original, largest);
			Console.ReadLine();

		}//end Main
	}//end Program
}
