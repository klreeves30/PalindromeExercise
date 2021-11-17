using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("madam", true)]
        [InlineData("racecar", true)]
        [InlineData("level", true)]
        [InlineData("kayak", true)]
        [InlineData("nurse", false)]
        [InlineData("doctor", false)]
        [InlineData("topper", false)]

        public void IsAPalindrome(string word, bool expected)
        {
            //Arrange
            var tester = new WordSmith();

            //Act
            bool actual = tester.IsAPalindrome(word);

            //Arrange
            Assert.Equal(expected, actual);

        }
    }
}
