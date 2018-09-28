using System;
using NUnit.Framework;
using StaticClasses;

namespace HelperClasses.UnitTests
{
	[TestFixture]
	public class FactorsTests
	{
		[Test]
		[TestCase((uint)10, new uint[] { 1, 2, 5, 10 })]
		[TestCase((uint)100, new uint[] { 1, 2, 4, 5, 10, 20, 25, 50, 100 })]
		public void GetAllFactors_SupportedValueGiven_ReturnsArrayOfFactors(uint baseNumber, uint[] expectedResult)
		{
			uint[] result = Factors.GetAllFactors(baseNumber);

			Assert.That(result, Is.EquivalentTo(expectedResult));
		}

		[Test]
		public void GetAllFactors_SupportedValueGiven_ReturnsCorrectSizeArray()
		{
			uint[] result = Factors.GetAllFactors(10);

			Assert.That(result.Length, Is.EqualTo(4));
		}

		[Test]
		public void GetAllFactors_TooLargeValueGiven_ThrowsOverflowException()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Factors.GetAllFactors(2147483648));
		}

		[Test]
		public void GetAllFactors_TooSmallValueGiven_ThrowsExeption()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Factors.GetAllFactors(0));
		}

		[Test]
		public void GetPrimeFactors_SupportedValueGiven_ReturnsArrayOfFactors()
		{
			uint[] results = Factors.GetPrimeFactors(10);

			Assert.That(results, Is.EquivalentTo(new uint[] { 1, 2, 5 }));
		}

		[Test]
		public void GetPrimeFactors_SupportedValueGiven_ReturnsCorrectSizeArray()
		{
			uint[] results = Factors.GetPrimeFactors(10);

			Assert.That(results.Length, Is.EqualTo(3));
		}

		[Test]
		public void GetPrimeFactors_TooLargeValueGiven_ThrowsOverflowException()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Factors.GetPrimeFactors(2147483648));
		}

		[Test]
		public void GetPrimeFactors_TooSmallValueGiven_ThrowsExeption()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Factors.GetPrimeFactors(0));
		}

	}
}
