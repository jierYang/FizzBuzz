using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private const int MinValue = 1;

        public static IList<string> GetFizzBuzz(int maxValue)
        {
            if (maxValue < MinValue)
            {
                throw new Exception(ErrorMessage.MinValueLessMaxValue);
            }

            var result = new List<string>();

            for (var i = MinValue; i <= maxValue; i++)
            {
                var str = GetValue(i);

                str = FizzBuzzContainsThreeOrFive(str);
                
                result.Add(str);
            }

            return result;
        }

        private static string FizzBuzzContainsThreeOrFive(string str)
        {
            if (str.Contains("3"))
            {
               return "Fizz";
            }

            if (str.Contains("5"))
            {
                return "Buzz";
            }

            return str;
        }
        
        private static string GetValue(int number)
        {
            if (number % 15 == 0) return "FizzBuzz";

            if (number % 3 == 0) return "Fizz";

            if (number % 5 == 0) return "Buzz";

            return number.ToString();
        }
    }
}