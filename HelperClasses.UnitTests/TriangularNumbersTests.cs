using System;

using FluentAssertions;
using StaticClasses;

using Xunit;

namespace HelperClasses.UnitTests
{
    public class TriangularNumbersTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 3)]
        [InlineData(7, 28)]
        public void GetNthTriangular_ValidValue_ReturnsTriangularNumber( int triangleToGet, int expectedResult)
        {
            int result = TriangularNumbers.GetNthTriangular(triangleToGet);

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(13, 15)]
        [InlineData(16, 15)]
        [InlineData(25, 28)]
        public void GetCLosestTriangular_ValidValue_ReturnsClosestTriangular( int baseNumber, int expectedResult )
        {
            int result = TriangularNumbers.GetClosestTriangular(baseNumber);

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(21, true)]
        [InlineData(28, true)]
        //[InlineData(20, false)]
        //[InlineData(27, false)]
        public void IsTriangular_ValueValue_ReturnsTrueOrFalse(int testNumber, bool expectedResult)
        {
            bool result = TriangularNumbers.IsTriangular(testNumber);

            result.Should().Be(expectedResult);
        }
    }
}
