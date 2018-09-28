using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StaticClasses;

namespace Tester
{
	class Program
	{
		static void Main ( string[] args )
		{
			//uint triangular = TriangularNumbers.GetNthTriangular(1224);
			//uint[] factors = Factors.GetAllFactors(triangular);

			//Console.WriteLine(factors.Length);

			//for (int i = 0; i < factors.Length; i++)
			//{
			//	Console.WriteLine("Factor {0} - Value: {1} - Base: {2} - Modulo: {3}", i + 1, factors[i], triangular, triangular % factors[i]);
			//}

			//Console.ReadLine();
			Stopwatch timer = new Stopwatch();

			int baseValue = 1000000000;
			int halfBase = baseValue / 2;

			timer.Start();
			for (int i = 0; i < baseValue / 2; i++)
			{

			}
			timer.Stop();

			Console.WriteLine("")

			Console.ReadLine();
		}
	}
}
