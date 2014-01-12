using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem._2
{
    class Program
    {
        static void Main()
        {
            var fibList = GetFibList(4000000);
            var result = fibList.Where(n => n % 2 == 0).ToList().Sum();

            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }

        static List<long> GetFibList(long limit)
        {
            var fibList = new List<long> { 1, 2 };
            long nextTerm;

            do
            {
                nextTerm = fibList.Skip(fibList.Count - 2).Sum();
                fibList.Add(nextTerm);
            }
            while (nextTerm < limit);
            
            return fibList;
        }
    }
}
