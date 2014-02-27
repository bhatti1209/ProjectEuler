using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem._9
{
    /*
        A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
            a^2 + b^2 = c^2

        For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

        There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        Find the product abc.
     */

    class Program
    {
        static void Main()
        {
            const int Limit = 1000;
            long sumOfTriplet = 3;
            var triplet = new List<long> { 1, 2, 3 };

            while (sumOfTriplet != Limit)
            {
                triplet = GetNextPythagoreanTriplet(triplet[0], triplet[1], triplet[2] + 1, Limit);
                sumOfTriplet = triplet.Sum();
            }

            Console.WriteLine("Result :" + triplet.Aggregate((a, b) => a * b));
            Console.ReadKey();
        }

        private static List<long> GetNextPythagoreanTriplet(long seedA, long seedB, long seedC, int limit)
        {
            while (! IsPythagoreanTriplet(seedA, seedB, seedC))
            {
                if (seedB + seedC >= limit)
                {
                    seedA++;
                    seedB = seedA + 1;
                    seedC = seedB + 1;
                }
                else if (seedC > limit / 2)
                {
                    seedB++;
                    seedC = seedB + 1;
                }
                else
                {
                    seedC++;
                }
            }

            return new List<long>{seedA, seedB, seedC};
        }

        private static bool IsPythagoreanTriplet(long a, long b, long c)
        {
            var isTriplet = false;

            if (a < b && b < c)
            {
                if (((a * a) + (b * b)) == c * c)
                {
                    isTriplet = true;
                }
            }

            return isTriplet;
        }
    }
}
