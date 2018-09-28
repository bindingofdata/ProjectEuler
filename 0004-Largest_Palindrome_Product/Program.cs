using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0004_Largest_Palindrome_Product
{
	class Program
	{
		static void Main(string[] args)
		{

			Stopwatch timer = new Stopwatch();
			/*
			 * A palindromic number reads the same both ways. 
			 * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
			 * Find the largest palindrome made from the product of two 3-digit numbers.
			 */
			int numberOfDigits = 0;
			long largestProduct = 0;

			Console.WriteLine("Calculate the largest palindromic number made from the product of two numbers.");
			Console.WriteLine("You decide how many digits the base numbers have.");
			Console.WriteLine();

			//get number of digits from user.
			Console.Write("How many digits should your base numbers have? ");
			numberOfDigits = Int32.Parse(Console.ReadLine());
			timer.Start();


			//calculate the largest possible number to start at
			largestProduct = calculateLargestProduct(numberOfDigits);

			for (long i = largestProduct; i >= largestProduct / 2; i--)
			{
				if (isPalindrome(i))
				{
					if (hasWholeBases(numberOfDigits, i))
					{
						//Console.Clear();
						Console.WriteLine("The largest palindromic product of two {0} digit numbers is {1}", numberOfDigits, i);
						break;
					}
				}
			}
			timer.Stop();
			Console.WriteLine( timer.Elapsed );


			Console.ReadLine();
		}

		public static bool hasWholeBases(int digits, long product)
		{
			int maxBase = createMaxBase(digits);
			int minBase = createMinBase(digits);

			for (int i = maxBase; i >= minBase; i--)
			{
				if (product % i == 0)
				{
					long number = product / i;
					if (number.ToString().Length <= digits)
					{
						Console.WriteLine("{0} * {1} = {2}", i, product / i, product);
						return true;
					}
				}
			}

			return false;
		}

		public static long calculateLargestProduct(int digits)
		{
			int baseNumber = createMaxBase(digits);
			return baseNumber * baseNumber;
		}

		public static int createMaxBase(int digits)
		{
			string numberHolder = "";

			for (int i = 0; i < digits; i++)
			{
				numberHolder += "9";
			}

			return Int32.Parse(numberHolder);
		}

		public static int createMinBase(int digits)
		{
			string numberHolder = "1";

			for (int i = 0; i < digits - 1; i++)
			{
				numberHolder += "0";
			}

			return Int32.Parse(numberHolder);
		}

		public static bool isPalindrome(long number)
		{
			bool isPalindrom = false;
			long reversedNumber = reverseNumber(number);

			if (number == reversedNumber)
			{
				isPalindrom = true;
			}

			return isPalindrom;
		}

		public static long reverseNumber(long number)
		{
			string numberString = number.ToString();
			string reversedString = "";
			long reversedNumber = 0;

			for (int i = numberString.Length - 1; i >= 0; i--)
			{
				reversedString += numberString[i];
			}

			reversedNumber = Int64.Parse(reversedString);
			return reversedNumber;
		}
	}
}
