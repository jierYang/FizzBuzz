using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private const int MinValue = 1;

        public static IList<string> GetFizzBuzz(int maxValue)
        {
            var numbers = Enumerable.Range(MinValue, maxValue).ToList();

            var result = FizzBuzzTranslate(numbers);

            return result;
        }

        private static IList<string> FizzBuzzTranslate(List<int> numbers)
        {
            var result = new List<string>();
            
            foreach (var number in numbers)
            {
                result.Add(number % 3 == 0 ? "Fizz" : number.ToString());
            }

            return result;
        }
    }
}