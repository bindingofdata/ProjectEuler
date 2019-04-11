using System;

namespace StaticClasses
{
    public static class Factors
    {
		public static int[] GetAllFactors(int baseNumber)
		{
			if (baseNumber < 1 || baseNumber >= int.MaxValue)
				throw new ArgumentOutOfRangeException();

			int totalFactors = 1;
            int halfBase = baseNumber / 2;
            int[] primes = GetPrimeFactors(baseNumber);
			bool[] tmpAllFactors = new bool[halfBase + 1];
			tmpAllFactors[1] = true;

            int[] allFactors;

			for (int i = 1; i < primes.Length; i++)
			{
				for (int j = primes[i]; j <= halfBase; j += primes[i])
				{
					if (baseNumber % j == 0 && !tmpAllFactors[j])
					{
						tmpAllFactors[j] = true;
						totalFactors++;
					}
				}
			}

			totalFactors++; // Account for base value being a factor of itself

			allFactors = new int[totalFactors];
            int factorIndex = 0;

			for (int i = 0; i < tmpAllFactors.Length; i++)
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

		public static int[] GetPrimeFactors(int baseNumber )
		{
			if (baseNumber < 1 || baseNumber >= int.MaxValue)
				throw new ArgumentOutOfRangeException();

            int maxTestValue = baseNumber / 2;

			int totalFactors = 0;
            int[] primesToTest = Primes.GetPrimes( maxTestValue );
            int[] tmpPrimeFactors = new int[primesToTest.Length];
            int[] primeFactors;

			for (int i = 0; i < primesToTest.Length; i++)
			{
				if (baseNumber % primesToTest[i] == 0)
				{
					tmpPrimeFactors[totalFactors] = primesToTest[i];
					totalFactors++;
				}
			}

			primeFactors = new int[totalFactors];

			for (int i = 0; i < totalFactors; i++)
			{
				primeFactors[i] = tmpPrimeFactors[i];
			}

			return primeFactors;
		}// End GetPrimeFactors
	}// end class
}
