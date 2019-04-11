using System;
using NUnit.Framework;
using StaticClasses;

namespace HelperClasses.UnitTests
{
	[TestFixture]
	public class SequencesTests
	{
		[Test]
		[TestCase(1, new int[] { 1 })]
		[TestCase(2, new int[] { 1, 2 })]
		[TestCase(10, new int[] { 1, 2, 3, 5, 8 })]
		public void GetFibonacciSequenceTo_ValidMaxValue_ReturnsSequenceToMaxValue(int maxValue, int[] expectedResult)
		{
            int[] results = Sequences.GetFibonacciSequenceTo(maxValue);

			Assert.That(results, Is.EquivalentTo(expectedResult));
		}

		[Test]
		public void GetFibonacciSequenceTo_InvalidMaxValue_ThrowsArgumentOutOfRangeException()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Sequences.GetFibonacciSequenceTo(0));
		}

		[Test]
		[TestCase(1, new int[] { 1 })]
		[TestCase(2, new int[] { 1, 2 })]
		[TestCase(5, new int[] { 1, 2, 3, 5, 8 })]
		public void GetNFibonacciNumbers_ValidNumberOfResults_ReturnsRequestedNumberOfValues(int maxValue, int[] expectedResult)
		{
            int[] results = Sequences.GetNFibonacciNumbers(maxValue);

			Assert.That(results, Is.EquivalentTo(expectedResult));
		}

		[Test]
		public void GetNFibonacciNumbers_InvalidNumberOfResults_ReturnsRequestedNumberOfValues()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Sequences.GetFibonacciSequenceTo(0));
		}
	}
}
