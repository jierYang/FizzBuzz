using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzTests
    {
        [Fact]
        public void WhenInputNumberShouldGetOneToNumberStringList()
        {
            var maxValue = 5;

            var result = FizzBuzz.GetFizzBuzz(maxValue);
            
            Assert.Equal(result.Count, maxValue);
        }
    }
}