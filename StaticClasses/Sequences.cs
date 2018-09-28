using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
	public static class Sequences
	{

		#region Fibonacci
		/// <summary>
		/// Returns an array of uints in a Fibonacci sequence with 
		/// a value less than or equal to the max value provided.
		/// Limited to 100000000 total items.
		/// </summary>
		/// <param name="maxNumber">Max value of a Fibonacci number</param>
		/// <returns>Fibonacci array</returns>
		public static uint[] GetFibonacciSequenceTo ( uint maxNumber )
		{
			if (maxNumber < 1)
				throw new ArgumentOutOfRangeException();
			if (maxNumber == 1)
				return new uint[] { 1 };
			else if (maxNumber == 2)
				return new uint[] { 1, 2 };

			uint[] tempSequence = new uint[100000000];
			int sequenceCount = 2;
			int valueAIndex = 0;
			int valueBIndex = 1;

			tempSequence[0] = 1;
			tempSequence[1] = 2;

			for (int i = 2; i < tempSequence.Length; i++)
			{
				tempSequence[i] = tempSequence[valueAIndex] + tempSequence[valueBIndex];
				valueAIndex++;
				valueBIndex++;

				if (tempSequence[i] > maxNumber)
					break;

				sequenceCount++;
			}

			uint[] sequence = new uint[sequenceCount];

			for (int i = 0; i < sequenceCount; i++)
			{
				sequence[i] = tempSequence[i];
			}

			return sequence;
		}

		/// <summary>
		/// Returns an array containing N number of numbers in a Fibonacci sequence.
		/// </summary>
		/// <param name="valueCount">Number of items to return</param>
		/// <returns>An array of N size with a Fibonacci sequence</returns>
		public static uint[] GetNFibonacciNumbers(uint valueCount)
		{
			if (valueCount < 1)
				throw new ArgumentOutOfRangeException();
			else if (valueCount == 1)
				return new uint[] { 1 };
			else if (valueCount == 2)
				return new uint[] { 1, 2 };

			uint[] sequence = new uint[valueCount];
			int indexA = 0;
			int indexB = 1;

			sequence[0] = 1;
			sequence[1] = 2;

			for (int i = 2; i < valueCount; i++)
			{
				sequence[i] = sequence[indexA] + sequence[indexB];
				indexA++;
				indexB++;
			}

			return sequence;
		}
		#endregion

		
	}// End Class
}
