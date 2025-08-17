using System;

using FluentAssertions;
using StaticClasses;

using Xunit;

namespace HelperClasses.UnitTests
{
    public class FactorsTests
    {
        [Theory]
        [InlineData(10, new int[] { 1, 2, 5, 10 })]
        [InlineData(100, new int[] { 1, 2, 4, 5, 10, 20, 25, 50, 100 })]
        public void GetAllFactors_WithValidInput_ReturnsExpectedFactors(int baseNumber, int[] expectedResult)
        {
            int[] results = Factors.GetAllFactors(baseNumber);

            results.Should().ContainInConsecutiveOrder(expectedResult);
        }

        [Fact]
        public void GetAllFactors_WithValidInput_ReturnsCorrectCount()
        {
            int[] results = Factors.GetAllFactors(10);

            results.Should().HaveCount(4);
        }

        [Fact]
        public void GetAllFactors_WithZeroInput_ThrowsArgumentOutOfRangeException()
        {
            Action action = () => Factors.GetAllFactors(0);

            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void GetPrimeFactors_WithValidInput_ReturnsExpectedPrimeFactors()
        {
            int[] results = Factors.GetPrimeFactors(10);

            results.Should().ContainInConsecutiveOrder([1, 2, 5]);
        }

        [Fact]
        public void GetPrimeFactors_WithValidInput_ReturnsCorrectCount()
        {
            int[] results = Factors.GetPrimeFactors(10);

            results.Should().HaveCount(3);
        }

        [Fact]
        public void GetPrimeFactors_WithZeroInput_ThrowsArgumentOutOfRangeException()
        {
            Action action = () => Factors.GetPrimeFactors(0);

            action.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}
