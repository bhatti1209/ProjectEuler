using System;
using System.Linq;

namespace Problem._1
{
    /*
        If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        Find the sum of all the multiples of 3 or 5 below 1000.
     */

    class Program
    {
        static void Main()
        {
            var result = Enumerable.Range(1, 999).ToList()
                                .Where(i => (i % 3 == 0 || i % 5 == 0))
                                .Sum();

            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
    }
}
