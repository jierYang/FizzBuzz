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

            return numbers.ConvertAll<string>(x => x.ToString());
        }
    }
}