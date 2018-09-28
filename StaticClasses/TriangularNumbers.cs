using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
	public static class TriangularNumbers
	{
		public static uint GetNthTriangular(uint nthValue)
		{
			return (nthValue * (nthValue + 1)) / 2;
		}

		public static int GetClosestTriangular(int number)
		{
			int result = 0;

			/*
			def close_triangle2(n):
			 m = int(0.5 * (-1 + sqrt(1 + 8 * n))) #solve it for the explicit formula
			 tan0 = (m * m + m) / 2              #the closest one is either this
			 tan1 = (m * m + 3 * m + 2) / 2          #or this
			 if (n - tan0)> (tan1 - n):
			     return tan1 - n
			 else:
			     return n - tan0
			*/

			int m = (int)(0.5 * (-1 + Math.Sqrt(1 + 8 * number)));
			int tan0 = (m * m + m) / 2;
			int tan1 = (m * m + 3 * m + 2) / 2;

			if (Math.Abs(number - tan0) > Math.Abs(number - tan1))
				result = tan1;
			else
				result = tan0;

			return result;
		}

		public static bool IsTriangular(uint testNumber)
		{
			return true;
		}
	}
}
