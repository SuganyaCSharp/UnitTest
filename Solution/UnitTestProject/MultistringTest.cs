using solution;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTestProject
{
    public class MultistringTest
    {
        [Fact]
        public void MultiTest()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.Multiplystr("a",5);
            //Assert
            Assert.Equal("aaaaa", z);
        }
        [Fact]
        public void MultiTest1()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.Multiplystr("abcd", 3);
            //Assert
            Assert.Equal("abcdabcdabcd", z);
        }
        [Fact]
        public void MultiTest2()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.Multiplystr("sugu123", 0);
            //Assert
            Assert.Equal("", z);
        }
        [Fact]
        public void MultiTest5()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.Multiplystr("venkat", 1);
            //Assert
            Assert.Equal("venkat", z);
        }
    }
}
