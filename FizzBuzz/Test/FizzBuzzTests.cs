using System;
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
            var maxValue = 3;

            var expect = new List<string> {"1", "2", "Fizz"};

            //Act
            var result = FizzBuzz.GetFizzBuzz(maxValue);

            //Assert
            Assert.Equal(result, expect);
        }

        [Fact]
        public void WhenInput5ShouldGetFizzReplace3AndBuzzReplace5InNumberStringList()
        {
            //Arrange
            var maxValue = 5;

            var expect = new List<string> {"1", "2", "Fizz", "4", "Buzz"};

            //Act
            var result = FizzBuzz.GetFizzBuzz(maxValue);

            //Assert
            Assert.Equal(result, expect);
        }

        [Fact]
        public void WhenInput15ShouldGetFizzBuzzReplace15InNumberStringList()
        {
            //Arrange
            var maxValue = 15;

            //Act
            var result = FizzBuzz.GetFizzBuzz(maxValue);

            //Assert
            Assert.Equal("FizzBuzz", result[14]);
        }

        [Fact]
        public void WhenInputIsLessThanMinValueShouldThrowException()
        {
            //Arrange
            var maxValue = 0;
            
            //Assert
            var exception = Assert.Throws<Exception>(() => FizzBuzz.GetFizzBuzz(maxValue));
            
            Assert.Equal(exception.Message, ErrorMessage.MinValueLessMaxValue);
        }

        [Fact]
        public void WhenInput13ShouldGetFizz()
        {
            //Arrange
            var maxValue = 13;

            //Act
            var result = FizzBuzz.GetFizzBuzz(maxValue);

            //Assert
            Assert.Equal("Fizz", result[12]);
        }
    }
}