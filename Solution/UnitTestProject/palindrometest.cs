using solution;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTestProject
{
    public class palindrometest
    {
        [Fact]
        public void palindrome()
        {
            //arrange
            var solution= new Solution();
            //Act
            var z = solution.Palindrome(121);
            //Assert
            Assert.True(z);
        }
        [Fact]
        public void palindrome11()
        {
            //arrange
            var solution = new Solution();
            //Act
            var z = solution.Palindrome(121);
            //Assert
            Assert.True(z);
        }
        [Fact]
        public void palindrome1()
        {
            //arrange
            var solution = new Solution();
            //Act
            var z = solution.Palindrome(-121);
            //Assert
            Assert.False(z);
        }
        [Fact]
        public void palindrome2()
        {
            //arrange
            var solution = new Solution();
            //Act
            var z = solution.Palindrome(1001);
            //Assert
            Assert.True(z);
        }
        [Fact]
        public void palindrome3()
        {
            //arrange
            var solution = new Solution();
            //Act
            var z = solution.Palindrome(123321);
            //Assert
            Assert.True(z);
        }
    }
}
