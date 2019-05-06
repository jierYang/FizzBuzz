using System.Collections.Generic;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzTests
    {
        [Fact]
        public void WhenInputNumberShouldGetOneToNumberStringList()
        {
            //Arrange
            var maxValue = 5;

            //Act
            var result = FizzBuzz.GetFizzBuzz(maxValue);
            
            //Assert
            Assert.Equal(result.Count, maxValue);
        }
        
        [Fact]
        public void WhenInput3ShouldGetFizzReplace3InNumberStringList()
        {
            //Arrange
            var maxValue = 6;

            var expect = new List<string> {"1", "2", "Fizz", "4", "5", "Fizz"};

            //Act
            var result = FizzBuzz.GetFizzBuzz(maxValue);
            
            //Assert
            Assert.Equal(result, expect);
        }
    }
}