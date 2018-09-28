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
			uint[] result = Primes.GetPrimes(5);

			Assert.That(result, Is.EquivalentTo(new int[] { 1, 2, 3, 5 }));
		}

		[Test]
		public void GetPrimes_ValidMaxValue_ReturnsCorrectSizedArray()
		{
			uint[] result = Primes.GetPrimes(5);

			Assert.That(result.Length, Is.EqualTo(4));
		}

		[Test]
		[TestCase((uint)0)]
		[TestCase((uint)int.MaxValue)]
		public void GetPrimes_InvalidValues_ThrowsArgumentOutOfRangeException(uint maxValue)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Primes.GetPrimes(maxValue));
		}

		[Test]
		[TestCase((uint)1, false)]
		[TestCase((uint)2, true)]
		[TestCase((uint)3, true)]
		[TestCase((uint)97, true)]
		[TestCase((uint)98, false)]
		public void IsPrime_ValidValues_ReturnsIfValueIsPrime(uint testValue, bool expectedResult)
		{
			bool result = Primes.IsPrime(testValue);

			Assert.That(result, Is.EqualTo(expectedResult));
		}
	}
}
