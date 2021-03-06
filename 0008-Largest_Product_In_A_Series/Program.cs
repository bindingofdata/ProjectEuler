﻿using System;
using System.Text;

namespace _0008_Largest_Product_In_A_Series
{
    class Program
	{
		static void Main(string[] args)
		{
			/*
			 * The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
					73167176531330624919225119674426574742355349194934
					96983520312774506326239578318016984801869478851843
					85861560789112949495459501737958331952853208805511
					12540698747158523863050715693290963295227443043557
					66896648950445244523161731856403098711121722383113
					62229893423380308135336276614282806444486645238749
					30358907296290491560440772390713810515859307960866
					70172427121883998797908792274921901699720888093776
					65727333001053367881220235421809751254540594752243
					52584907711670556013604839586446706324415722155397
					53697817977846174064955149290862569321978468622482
					83972241375657056057490261407972968652414535100474
					82166370484403199890008895243450658541227588666881
					16427171479924442928230863465674813919123162824586
					17866458359124566529476545682848912883142607690042
					24219022671055626321111109370544217506941658960408
					07198403850962455444362981230987879927244284909188
					84580156166097919133875499200524063689912560717606
					05886116467109405077541002256983155200055935729725
					71636269561882670428252483600823257530420752963450
			 * Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
			 */
			
			long largestProduct = 0;
			long testProduct = 0;
			int numberOfFactors = 13;
			string sourceFactors = CreateSource();
			string currentFactors = "";
			string largestFactors = "";

			for (int i = 0; i < sourceFactors.Length - numberOfFactors; i++)
			{
				currentFactors = sourceFactors.Substring(i, numberOfFactors);
				testProduct = CreateProduct(currentFactors);
				if (testProduct > largestProduct)
				{
					largestProduct = testProduct;
					largestFactors = currentFactors;
				}
			}

			Console.WriteLine("The source number has {0} digits:", sourceFactors.Length);
			Console.WriteLine("{0}", sourceFactors);
			Console.WriteLine("----------------------------------------------------------");
			Console.WriteLine("The largest product of {0} consecutive digits ({1}) is {2}", numberOfFactors, largestFactors, largestProduct);
			Console.ReadLine();
		}

		public static long CreateProduct(string sourceString)
		{
			long product = 1;
			for (int i = 0; i < sourceString.Length; i++)
			{
				product *= int.Parse(sourceString.Substring(i, 1));
			}
			return product;
		}

		public static string CreateSource()
		{
            StringBuilder sourceString = new StringBuilder();
            sourceString.Append( "73167176531330624919225119674426574742355349194934" );
            sourceString.Append( "96983520312774506326239578318016984801869478851843" );
            sourceString.Append( "85861560789112949495459501737958331952853208805511" );
            sourceString.Append( "12540698747158523863050715693290963295227443043557" );
            sourceString.Append( "66896648950445244523161731856403098711121722383113" );
            sourceString.Append( "62229893423380308135336276614282806444486645238749" );
            sourceString.Append( "30358907296290491560440772390713810515859307960866" );
            sourceString.Append( "70172427121883998797908792274921901699720888093776" );
            sourceString.Append( "65727333001053367881220235421809751254540594752243" );
            sourceString.Append( "52584907711670556013604839586446706324415722155397" );
            sourceString.Append( "53697817977846174064955149290862569321978468622482" );
            sourceString.Append( "83972241375657056057490261407972968652414535100474" );
            sourceString.Append( "82166370484403199890008895243450658541227588666881" );
            sourceString.Append( "16427171479924442928230863465674813919123162824586" );
            sourceString.Append( "17866458359124566529476545682848912883142607690042" );
            sourceString.Append( "24219022671055626321111109370544217506941658960408" );
            sourceString.Append( "07198403850962455444362981230987879927244284909188" );
            sourceString.Append( "84580156166097919133875499200524063689912560717606" );
            sourceString.Append( "05886116467109405077541002256983155200055935729725" );
            sourceString.Append( "71636269561882670428252483600823257530420752963450" );

			return sourceString.ToString();
		}
	}
}
