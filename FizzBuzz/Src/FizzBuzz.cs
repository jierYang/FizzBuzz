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

            var numbers = Enumerable.Range(MinValue, maxValue).ToList();

            var result = FizzBuzzTranslate(numbers);

            FizzBuzzReplace(result);

            return result;
        }

        private static void FizzBuzzReplace(IList<string> result)
        {
            for (var i = 0; i < result.Count; i++)
            {
                if (result[i].Contains("3"))
                {
                    result[i] = "Fizz";
                }
            }
        }

        private static IList<string> FizzBuzzTranslate(List<int> numbers)
        {
            var result = new List<string>();

            foreach (var number in numbers)
            {
                result.Add(GetValue(number));
            }

            return result;
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