using System;

using FluentAssertions;
using ExtensionClasses;

using Xunit;

namespace HelperClasses.UnitTests
{
    public class SequencesTests
    {
        [Theory]
        [InlineData(1, new int[] { 1 })]
        [InlineData(2, new int[] { 1, 2 })]
        [InlineData(10, new int[] { 1, 2, 3, 5, 8 })]
        public void GetFibonacciSequenceTo_WithValidMaxValue_ReturnsExpectedSequence(int maxValue, int[] expectedResult)
        {
            int[] results = maxValue.GetFibonacciSequenceTo();

            results.Should().ContainInConsecutiveOrder(expectedResult);
        }

        [Fact]
        public void GetFibonacciSequenceTo_WithZeroInput_ThrowsArgumentOutOfRangeException()
        {
            Action action = () => 0.GetFibonacciSequenceTo();

            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, new int[] { 1 })]
        [InlineData(2, new int[] { 1, 2 })]
        [InlineData(5, new int[] { 1, 2, 3, 5, 8 })]
        public void GetNFibonacciNumbers_WithValidCount_ReturnsExpectedSequence(int maxValue, int[] expectedResult)
        {
            int[] results = maxValue.GetNFibonacciNumbers();

            results.Should().ContainInConsecutiveOrder(expectedResult);
        }

        [Fact]
        public void GetNFibonacciNumbers_WithZeroInput_ThrowsArgumentOutOfRangeException()
        {
            Action action = () => 0.GetFibonacciSequenceTo();

            action.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}
