using System;
using NUnit.Framework;
using StaticClasses;

namespace HelperClasses.UnitTests
{
	[TestFixture]
	public class SequencesTests
	{
		[Test]
		[TestCase((uint)1, new uint[] { 1 })]
		[TestCase((uint)2, new uint[] { 1, 2 })]
		[TestCase((uint)10, new uint[] { 1, 2, 3, 5, 8 })]
		public void GetFibonacciSequenceTo_ValidMaxValue_ReturnsSequenceToMaxValue(uint maxValue, uint[] expectedResult)
		{
			uint[] results = Sequences.GetFibonacciSequenceTo(maxValue);

			Assert.That(results, Is.EquivalentTo(expectedResult));
		}

		[Test]
		public void GetFibonacciSequenceTo_InvalidMaxValue_ThrowsArgumentOutOfRangeException()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Sequences.GetFibonacciSequenceTo(0));
		}

		[Test]
		[TestCase((uint)1, new uint[] { 1 })]
		[TestCase((uint)2, new uint[] { 1, 2 })]
		[TestCase((uint)5, new uint[] { 1, 2, 3, 5, 8 })]
		public void GetNFibonacciNumbers_ValidNumberOfResults_ReturnsRequestedNumberOfValues(uint maxValue, uint[] expectedResult)
		{
			uint[] results = Sequences.GetNFibonacciNumbers(maxValue);

			Assert.That(results, Is.EquivalentTo(expectedResult));
		}

		[Test]
		public void GetNFibonacciNumbers_InvalidNumberOfResults_ReturnsRequestedNumberOfValues()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Sequences.GetFibonacciSequenceTo(0));
		}
	}
}
