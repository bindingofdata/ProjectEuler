using System;
using System.Collections.Generic;

using StaticClasses;

namespace _0003_Largest_Prime_Factor
{
    internal static class Program
	{
		private static void Main(string[] args)
		{
			/*
			 * The prime factors of 13195 are 5, 7, 13 and 29.
			 * What is the largest prime factor of the number 600851475143 ?
			 */

			Console.WriteLine("Find the Largest Prime factor of a number!");
			Console.WriteLine("------------------------------------------");
			Console.WriteLine();
			Console.Write("Enter the number you want the Largest Prime factor of: ");
			int original = Convert.ToInt32(Console.ReadLine());
            int largest = 0;

            // Store all primes up to half the supplied number
            int[] primes = Primes.GetPrimes( original / 2 );

			// List to store all the prime factors of the supplied number
			List<int> primeFactors = new List<int>();

            foreach (int prime in primes)
                if (original % prime == 0)
                    primeFactors.Add(prime);

            foreach (int primeFactor in primeFactors)
                if (primeFactor > largest)
                    largest = primeFactor;

            Console.WriteLine();
			Console.WriteLine("The largest factor of {0} is {1}.", original, largest);
			Console.ReadLine();
		}//end Main
    }//end Program
}
