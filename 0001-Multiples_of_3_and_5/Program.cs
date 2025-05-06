using System;
using System.Collections.Generic;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Reports;

namespace _0001_Multiples_of_3_and_5
{
    public static class Program
    {
        static void Main(string[] args)
        {
#if RELEASE
            Summary summary = BenchmarkRunner.Run<MultiplesOf3And5>();
#endif
#if RELEASE == false
            /*
             * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
             * The sum of these multiples is 23.
             * Find the sum of all the multiples of 3 or 5 below 1000.
             */

            int sum = 0;

            Console.WriteLine("Sum of all multiples of two numbers!");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.Write("Enter your first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter your second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the number to sum multiples up to: ");
            int multiplyUpTo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //sum = SumOfMultiples(firstNumber, secondNumber, multiplyUpTo);
            sum = SumOfMultiplesSieve(firstNumber, secondNumber, multiplyUpTo);
            //sum = SumOfMultiplesLinq(firstNumber, secondNumber, multiplyUpTo);

            Console.WriteLine("The sum of all multiples is {0}", sum);
            Console.ReadLine();
#endif
        }

        // | SumOfMultiples      | 2,739.0 ns | 22.50 ns | 21.04 ns |
        public static int SumOfMultiples(int firstNumber, int secondNumber, int multiplyUpTo)
        {
            List<int> multiples = new();
            int sum = 0;
            // This is my original implementation. 
            for (int i = 0; i < multiplyUpTo; i++)
            {
                // Check for multiples of first and second number.
                if (i % firstNumber == 0)
                {
                    multiples.Add(i);
                    //Console.WriteLine("Multiple of {0} found: {1}", firstNumber, i);
                }
                else if (i % secondNumber == 0)
                {
                    multiples.Add(i);
                    //Console.WriteLine("Multiple of {0} found: {1}", secondNumber, i);
                }
            }

            foreach (int number in multiples)
            {
                sum += number;
            }

            return sum;
        }

        // | SumOfMultiplesSieve |   839.2 ns | 15.39 ns | 14.39 ns |
        public static int SumOfMultiplesSieve(int firstNumber, int secondNumber, int multiplyUpTo)
        {
            int sum = 0;
            // This is an updated implementation based on the Sieve of Eratosthenes
            int maxIndex = multiplyUpTo + 1;
            bool[] multiplesOfFirst = new bool[maxIndex];
            bool[] multiplesOfSecond = new bool[maxIndex];

            for (int i = firstNumber; i < multiplesOfFirst.Length; i += firstNumber)
                multiplesOfFirst[i] = true;

            for (int i = secondNumber; i < multiplesOfSecond.Length; i += secondNumber)
                multiplesOfSecond[i] = true;

            for (int i = 1; i < maxIndex; i++)
                if (multiplesOfSecond[i] || multiplesOfFirst[i])
                    sum += i;

            return sum;
        }

        // | SumOfMultiplesLinq  | 2,278.8 ns | 23.05 ns | 21.56 ns |
        public static int SumOfMultiplesLinq(int firstNumber, int secondNumber, int multiplyUpTo)
        {
            // This is my LINQ implementation
            return Enumerable.Range(1, multiplyUpTo)
                .Where(num => num % firstNumber == 0 || num % secondNumber == 0)
                .Sum();
        }
    }

    public class MultiplesOf3And5
    {
        int firstNumber = 3;
        int secondNumber = 5;
        int multiplesUpTo = 1000;

        [Benchmark]
        public int SumOfMultiples() =>
            Program.SumOfMultiples(firstNumber, secondNumber, multiplesUpTo);

        [Benchmark]
        public int SumOfMultiplesSieve() =>
            Program.SumOfMultiplesSieve(firstNumber, secondNumber, multiplesUpTo);

        [Benchmark]
        public int SumOfMultiplesLinq() =>
            Program.SumOfMultiplesLinq(firstNumber, secondNumber, multiplesUpTo);
    }
}
