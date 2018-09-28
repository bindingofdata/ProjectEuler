using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0009_Special_Pythagorean_Triplet
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
			 * a^2 + b^2 = c^2
			 * 
			 * For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
			 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
			 * Find the product abc.
			 */

			int maxTripletSum = 1000;
			int tripletSum = 12;
			int tripletsTried = 0;
			int a = 4;
			int b = 3;
			int c = 5;

			int seed1 = 5;
			int seed2 = 6;

			for (int i = seed1; i < (int) maxTripletSum / 2; i++)
			{
				for (int j = seed2; j < (int)maxTripletSum / 2; j++)
				{
					c = calculateC(i, j);

					if (c != 0)
					{
						a = i;
						b = j;
						tripletSum = a + b + c;
						tripletsTried += 1;

						if (tripletSum == maxTripletSum)
						{
							Console.WriteLine("Triplet match found after {0} tries!", tripletsTried);
							Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, maxTripletSum);
							Console.WriteLine("{0}^2 + {1}^2 = {2}^2", a, b, c);
							Console.WriteLine("{0} + {1} = {2}", a * a, b * b, c * c);
							Console.WriteLine("The product of a, b and c is {0}", a * b * c);
							Console.ReadLine();
							break;
						}

						j = maxTripletSum / 2;
					}
				}
			}

			Console.WriteLine("No valid triplets found out of {0} triplets tried.", tripletsTried);
			Console.ReadLine();
		}

		public static bool isTriplet(int c)
		{
			if (Math.Sqrt(c) % 1 == 0)
			{
				return true;
			}

			return false;
		}

		public static int calculateC(int seed1, int seed2)
		{
			int c = (seed1 * seed1) + (seed2 * seed2);
			if (isTriplet(c))
			{
				return (int) Math.Sqrt(c);
			}
			else
			{
				return 0;
			}
		}

	}
}
