using System;
using System.Linq;

namespace Problem._1
{
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
