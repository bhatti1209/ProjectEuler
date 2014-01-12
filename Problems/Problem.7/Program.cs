using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem._7
{
    /*
        By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        What is the 10 001st prime number?
     */

    class Program
    {
        private static void Main()
        {
            const int NthPrime = 10001;
            var primeList = new List<double> { 2, 3 };
            var result = 4;

            while (primeList.Count != NthPrime)
            {
                if (primeList.Any(prime => result % prime == 0))
                {
                    result++;
                }
                else
                {
                    primeList.Add(result);
                }
            }

            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
    }
}
