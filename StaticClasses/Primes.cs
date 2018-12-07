using System;

namespace StaticClasses
{
    public static class Primes
    {
		/// <summary>
		/// Returns a list containing all the prime numbers up to the specified number.
		/// </summary>
		/// <param name="maxValue">The max value to get primes up to.</param>
		/// <returns></returns>
		public static uint[] GetPrimes( uint maxValue )
		{
			if (maxValue < 1 || maxValue >= int.MaxValue)
				throw new ArgumentOutOfRangeException();

			uint[] allPrimes = CalculateAllPrimes(maxValue);

			return allPrimes;
		}//End GetPrimes

		public static bool IsPrime(uint testValue)
		{
			// Handle values less than or equal to 3.
			if (testValue < 2)
				return false;
			else if (testValue == 2 || testValue == 3)
				return true;
			else if (testValue % 2 == 0)
				return false;

			// Test values greater than 2 and fail if they can be divided evenly
			uint maxLoopIndex = (uint)Math.Sqrt(testValue);

			for (int i = 3; i < maxLoopIndex; i++)
			{
				if (testValue % i == 0)
					return false;
			}

			// If we get here, the value is prime.
			return true;
		}

		private static uint[] CalculateAllPrimes( uint maxValue )
		{
			maxValue++; //supports using index as value.
			bool[] calculatePrimes = new bool[maxValue];
			bool[] storePrimes = new bool[maxValue];
			uint primeCount = 1;
			uint[] primes;

			storePrimes[1] = true;
			for ( uint testInt = 2; testInt < maxValue; testInt++)
			{
				if (!calculatePrimes[testInt])
				{
					storePrimes[testInt] = true;
					primeCount++;
					for ( uint i = testInt; i < maxValue; i += testInt)
					{
						calculatePrimes[i] = true;
					}
				}
			}

			primes = new uint[primeCount];

			uint primeIndex = 0;
			for (uint i = 0; i < maxValue; i++)
			{
				if (storePrimes[i])
				{
					primes[primeIndex] = i;
					primeIndex++;
				}
			}

			return primes;
		}

    }
}
