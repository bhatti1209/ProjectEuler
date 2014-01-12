using System;

namespace Problem._5
{
    /*
        2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
     */
    class Program
    {
        static void Main()
        {
            const int DivisibleTill = 20;
            var result = 2;

            for (var q = 2; q <= DivisibleTill; q++)
            {
                var divisibleByAll = false;
                while (!divisibleByAll)
                {
                    var flag = true;
                    for (var a = 2; a <= q; a++)
                    {
                        if (result % a != 0)
                        {
                            result++;
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        divisibleByAll = true;
                    }
                }
            }

            Console.WriteLine("Result :" + result);
            Console.ReadKey();
        }
    }
}
