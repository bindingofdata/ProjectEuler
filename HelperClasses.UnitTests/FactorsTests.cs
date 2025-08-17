using System;

using FluentAssertions;
using ExtensionClasses;

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
            int[] results = baseNumber.GetAllFactors();

            results.Should().ContainInConsecutiveOrder(expectedResult);
        }

        [Fact]
        public void GetAllFactors_WithValidInput_ReturnsCorrectCount()
        {
            int[] results = 10.GetAllFactors();

            results.Should().HaveCount(4);
        }

        [Fact]
        public void GetAllFactors_WithZeroInput_ThrowsArgumentOutOfRangeException()
        {
            Action action = () => 0.GetAllFactors();

            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void GetPrimeFactors_WithValidInput_ReturnsExpectedPrimeFactors()
        {
            int[] results = 10.GetPrimeFactors();

            results.Should().ContainInConsecutiveOrder([1, 2, 5]);
        }

        [Fact]
        public void GetPrimeFactors_WithValidInput_ReturnsCorrectCount()
        {
            int[] results = 10.GetPrimeFactors();

            results.Should().HaveCount(3);
        }

        [Fact]
        public void GetPrimeFactors_WithZeroInput_ThrowsArgumentOutOfRangeException()
        {
            Action action = () => 0.GetPrimeFactors();

            action.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}
