using System;
using NUnit.Framework;
using StaticClasses;

namespace HelperClasses.UnitTests
{
	[TestFixture]
	public class FactorsTests
	{
		[Test]
		[TestCase(10, new uint[] { 1, 2, 5, 10 })]
		[TestCase(100, new uint[] { 1, 2, 4, 5, 10, 20, 25, 50, 100 })]
		public void GetAllFactors_SupportedValueGiven_ReturnsArrayOfFactors(int baseNumber, int[] expectedResult)
		{
            int[] result = Factors.GetAllFactors(baseNumber);

			Assert.That(result, Is.EquivalentTo(expectedResult));
		}

		[Test]
		public void GetAllFactors_SupportedValueGiven_ReturnsCorrectSizeArray()
		{
            int[] result = Factors.GetAllFactors(10);

			Assert.That(result.Length, Is.EqualTo(4));
		}

		[Test]
		public void GetAllFactors_TooSmallValueGiven_ThrowsExeption()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Factors.GetAllFactors(0));
		}

		[Test]
		public void GetPrimeFactors_SupportedValueGiven_ReturnsArrayOfFactors()
		{
            int[] results = Factors.GetPrimeFactors(10);

			Assert.That(results, Is.EquivalentTo(new int[] { 1, 2, 5 }));
		}

		[Test]
		public void GetPrimeFactors_SupportedValueGiven_ReturnsCorrectSizeArray()
		{
            int[] results = Factors.GetPrimeFactors(10);

			Assert.That(results.Length, Is.EqualTo(3));
		}

		[Test]
		public void GetPrimeFactors_TooSmallValueGiven_ThrowsExeption()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Factors.GetPrimeFactors(0));
		}
	}
}
