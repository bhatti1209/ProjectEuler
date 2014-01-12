using System;
using System.Linq;

namespace Problem._6
{
    /*
        The sum of the squares of the first ten natural numbers is,
        1^2 + 2^2 + ... + 10^2 = 385
        The square of the sum of the first ten natural numbers is,
        (1 + 2 + ... + 10)^2 = 55^2 = 3025
        Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
     */

    class Program
    {
        private static void Main()
        {
            const int MaxRange = 100;

            var numberList = Enumerable.Range(1, MaxRange).ToList();
            var sumOfList = numberList.Sum();
            var squareOfSum = sumOfList * sumOfList;

            var listOfSumOfSquare = numberList.Select(n => n * n);
            var sumOfSumOfSquare = listOfSumOfSquare.Sum();

            var result = squareOfSum - sumOfSumOfSquare;
            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
    }
}
