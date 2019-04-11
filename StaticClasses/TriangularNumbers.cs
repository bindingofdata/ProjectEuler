using System;

namespace StaticClasses
{
    public static class TriangularNumbers
	{
		public static int GetNthTriangular(int nthValue)
		{
			return (nthValue * (nthValue + 1)) / 2;
		}

		public static int GetClosestTriangular(int number)
		{
            int m = (int)(0.5 * (-1 + Math.Sqrt(1 + (8 * number))));
            int tan0 = ((m * m) + m) / 2;
			int tan1 = ((m * m) + (3 * m) + 2) / 2;

            return Math.Abs(number - tan0) > Math.Abs(number - tan1) ? tan1 : tan0;
		}

		public static bool IsTriangular(int testNumber)
		{
			return true;
		}
	}
}
