using System;

using FluentAssertions;
using StaticClasses;

using Xunit;

namespace HelperClasses.UnitTests
{
    public class PrimesTests
    {
        [Fact]
        public void GetPrimes_WithMaxValueFive_ReturnsPrimesUpToFive()
        {
            int[] result = Primes.GetPrimes(5);

            result.Should().ContainInConsecutiveOrder([1, 2, 3, 5]);
        }

        [Fact]
        public void GetPrimes_WithMaxValueFive_ReturnsCountOfFour()
        {
            int[] result = Primes.GetPrimes(5);

            result.Should().HaveCount(4);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(int.MaxValue)]
        public void GetPrimes_WithZeroOrMaxInt_ThrowsArgumentOutOfRangeException(int maxValue)
        {
            Action action = () => Primes.GetPrimes(maxValue);

            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(97, true)]
        [InlineData(98, false)]
        public void IsPrime_WithVariousInputs_ReturnsExpectedBoolean(int testValue, bool expectedResult)
        {
            bool result = Primes.IsPrime(testValue);

            result.Should().Be(expectedResult);
        }
    }
}
