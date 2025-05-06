using System;
using System.Collections.Generic;
using System.Linq;

namespace _0001_Multiples_of_3_and_5
{
    public static class Program
    {
        static void Main(string[] args)
        {
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

            //sum = SumOfMultiples(firstNumber, secondNumber);
            //sum = SumOfMultiplesSieve(firstNumber, secondNumber);
            sum = SumOfMultiplesLinq(firstNumber, secondNumber);

            Console.WriteLine("The sum of all multiples is {0}", sum);
            Console.ReadLine();
        }

        public static int SumOfMultiples(int firstNumber, int secondNumber)
        {
            List<int> multiples = new();
            int sum = 0;
            // This is my original implementation. 
            for (int i = 0; i < 1000; i++)
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

        public static int SumOfMultiplesSieve(int firstNumber, int secondNumber)
        {
            int sum = 0;
            // This is an updated implementation based on the Sieve of Eratosthenes
            bool[] multiplesOfThree = new bool[1001];
            bool[] multiplesOfFive = new bool[1001];

            for (int i = 3; i < multiplesOfThree.Length; i += 3)
                multiplesOfThree[i] = true;

            for (int i = 5; i < multiplesOfFive.Length; i += 5)
                multiplesOfFive[i] = true;

            for (int i = 1; i < 1001; i++)
                if (multiplesOfFive[i] || multiplesOfThree[i])
                    sum += i;

            return sum;
        }

        public static int SumOfMultiplesLinq(int firstNumber, int secondNumber)
        {
            // This is my LINQ implementation
            return Enumerable.Range(1, 999)
                .Where(num => num % firstNumber == 0 || num % secondNumber == 0)
                .Sum();
        }
    }
}
