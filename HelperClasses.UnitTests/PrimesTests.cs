using System;
using NUnit.Framework;
using StaticClasses;

namespace HelperClasses.UnitTests
{
	[TestFixture]
	public class PrimesTests
	{
		[Test]
		public void GetPrimes_ValidMaxValue_ReturnsCorrectArrayOfValues()
		{
			int[] result = Primes.GetPrimes(5);

			Assert.That(result, Is.EquivalentTo(new int[] { 1, 2, 3, 5 }));
		}

		[Test]
		public void GetPrimes_ValidMaxValue_ReturnsCorrectSizedArray()
		{
            int[] result = Primes.GetPrimes(5);

			Assert.That(result.Length, Is.EqualTo(4));
		}

		[Test]
		[TestCase(0)]
		[TestCase(int.MaxValue)]
		public void GetPrimes_InvalidValues_ThrowsArgumentOutOfRangeException(int maxValue)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Primes.GetPrimes(maxValue));
		}

		[Test]
		[TestCase(1, false)]
		[TestCase(2, true)]
		[TestCase(3, true)]
		[TestCase(97, true)]
		[TestCase(98, false)]
		public void IsPrime_ValidValues_ReturnsIfValueIsPrime(int testValue, bool expectedResult)
		{
			bool result = Primes.IsPrime(testValue);

			Assert.That(result, Is.EqualTo(expectedResult));
		}
	}
}
