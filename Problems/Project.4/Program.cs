﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project._4
{
    using System.Globalization;

    class Program
    {
        static void Main()
        {
            const int MaxDigits = 3;
            double result = 1;
            var smallestNDigitNumber = Math.Pow(10, MaxDigits - 1);
            var largestNDigitNumber = Math.Pow(10, MaxDigits) - 1;

            for (var x = smallestNDigitNumber; x <= largestNDigitNumber; x++)
            {
                for (var y = x; y <= largestNDigitNumber; y++)
                {
                    var product = x * y;
                    if (IsPalindrome(product) &&  result < product)
                    {
                        result = product;
                    }
                }
            }

            Console.WriteLine("Largest Palindrome: " + result);
            Console.ReadKey();
        }

        static bool IsPalindrome(double number)
        {
            var stringValue = number.ToString(CultureInfo.InvariantCulture);
            var firstHalf = stringValue.Substring(0, stringValue.Length / 2);
            var secondHalf = string.Join("", stringValue.Substring(stringValue.Length / 2, stringValue.Length / 2).Reverse().ToArray());
            return firstHalf.Equals(secondHalf);
        }
    }
}
