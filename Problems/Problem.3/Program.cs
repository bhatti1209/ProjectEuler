using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem._3
{
    class Program
    {
        static void Main()
        {
            const long Number = 600851475143;
            var primeList = FindPrimes(Number);

            Console.WriteLine("Result : " + primeList.Last());
            Console.ReadKey();
        }

        static IEnumerable<long> FindPrimes(long inputNumber)
        {
            var primeList = new List<long>();
            do
            {
                var prime = LargestDivider(inputNumber);
                inputNumber /= prime;
                primeList.Add(prime);
            }
            while (inputNumber > primeList.Last());

            return primeList;
        }

        static long LargestDivider(long seedValue)
        {
            var divider = 2;

            while (seedValue % divider != 0)
            {
                divider++;
            }

            return divider;
        }
    }
}
