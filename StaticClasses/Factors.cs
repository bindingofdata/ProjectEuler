using System;

namespace StaticClasses
{
    public static class Factors
    {

		public static uint[] GetAllFactors(uint baseNumber)
		{
			if (baseNumber < 1 || baseNumber >= int.MaxValue)
				throw new ArgumentOutOfRangeException();

			uint totalFactors = 1;
			uint halfBase = baseNumber / 2;
			uint[] primes = GetPrimeFactors(baseNumber);
			bool[] tmpAllFactors = new bool[halfBase + 1];
			tmpAllFactors[1] = true;
			
			uint[] allFactors;

			for (int i = 1; i < primes.Length; i++)
			{
				for (uint j = primes[i]; j <= halfBase; j += primes[i])
				{
					if (baseNumber % j == 0 && tmpAllFactors[j] == false)
					{
						tmpAllFactors[j] = true;
						totalFactors++;
					}
				}
			}

			totalFactors++; // Account for base value being a factor of itself

			allFactors = new uint[totalFactors];
			uint factorIndex = 0;

			for (uint i = 0; i < tmpAllFactors.Length; i++)
			{
				if (tmpAllFactors[i])
				{
					allFactors[factorIndex] = i;
					factorIndex++;
				}
			}

			allFactors[allFactors.Length - 1] = baseNumber;

			return allFactors;
		}// end GetAllFactors

		public static uint[] GetPrimeFactors( uint baseNumber )
		{
			if (baseNumber < 1 || baseNumber >= int.MaxValue)
				throw new ArgumentOutOfRangeException();

			uint maxTestValue = baseNumber / 2;

			int totalFactors = 0;
			uint[] primesToTest = Primes.GetPrimes( maxTestValue );
			uint[] tmpPrimeFactors = new uint[primesToTest.Length];
			uint[] primeFactors;

			for (uint i = 0; i < primesToTest.Length; i++)
			{
				if (baseNumber % primesToTest[i] == 0)
				{
					tmpPrimeFactors[totalFactors] = primesToTest[i];
					totalFactors++;
				}
			}

			primeFactors = new uint[totalFactors];

			for (int i = 0; i < totalFactors; i++)
			{
				primeFactors[i] = tmpPrimeFactors[i];
			}

			return primeFactors;
		}// End GetPrimeFactors
		
		public static int FirstWithNFactors(int numberOfFators)
		{
			int result = 0;



			return result;
		}
	}// end class
}
