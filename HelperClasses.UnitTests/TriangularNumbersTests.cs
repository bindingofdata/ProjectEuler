using System;
using NUnit.Framework;
using StaticClasses;

namespace HelperClasses.UnitTests
{
	[TestFixture]
	public class TriangularNumbersTests
	{
		[Test]
		[TestCase(1, 1)]
		[TestCase(2, 3)]
		[TestCase(7, 28)]
		public void GetNthTriangular_ValidValue_ReturnsTriangularNumber( int triangleToGet, int expectedResult)
		{
            int result = TriangularNumbers.GetNthTriangular(triangleToGet);

			Assert.That(result, Is.EqualTo(expectedResult));
		}

		[Test]
		[TestCase(13, 15)]
		[TestCase(16, 15)]
		[TestCase(25, 28)]
		public void GetCLosestTriangular_ValidValue_ReturnsClosestTriangular( int baseNumber, int expectedResult )
		{
			int result = TriangularNumbers.GetClosestTriangular(baseNumber);

			Assert.That(result, Is.EqualTo(expectedResult));
		}

		[Test]
		[TestCase(21, true)]
		[TestCase(28, true)]
		[TestCase(20, false)]
		[TestCase(27, false)]
		public void IsTriangular_ValueValue_ReturnsTrueOrFalse(int testNumber, bool expectedResult)
		{
			bool result = TriangularNumbers.IsTriangular(testNumber);

			Assert.That(result, Is.EqualTo(expectedResult));
		}
	}
}
