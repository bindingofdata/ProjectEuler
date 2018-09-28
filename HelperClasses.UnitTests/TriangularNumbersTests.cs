using System;
using NUnit.Framework;
using StaticClasses;

namespace HelperClasses.UnitTests
{
	[TestFixture]
	public class TriangularNumbersTests
	{
		[Test]
		[TestCase((uint)1, (uint)1)]
		[TestCase((uint)2, (uint)3)]
		[TestCase((uint)7, (uint)28)]
		public void GetNthTriangular_ValidValue_ReturnsTriangularNumber( uint triangleToGet, uint expectedResult)
		{
			uint result = TriangularNumbers.GetNthTriangular(triangleToGet);

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
		[TestCase((uint)21, true)]
		[TestCase((uint)28, true)]
		[TestCase((uint)20, false)]
		[TestCase((uint)27, false)]
		public void IsTriangular_ValueValue_ReturnsTrueOrFalse(uint testNumber, bool expectedResult)
		{
			bool result = TriangularNumbers.IsTriangular(testNumber);

			Assert.That(result, Is.EqualTo(expectedResult));
		}
	}
}
