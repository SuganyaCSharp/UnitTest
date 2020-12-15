using solution;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTestProject
{
    public class TobinaryTest
    {
        [Fact]
        public void Tobinary()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.ToBinary(37);
            //Assert
            Assert.Equal("100101", z);
        }
        [Fact]
        public void Tobinary1()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.ToBinary(0);
            //Assert
            Assert.Equal("0", z);
        }
        [Fact]
        public void Tobinary2()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.ToBinary(1);
            //Assert
            Assert.Equal("1", z);
        }
        [Fact]
        public void Tobinary3()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.ToBinary(10);
            //Assert
            Assert.Equal("1010", z);
        }
        [Fact]
        public void Tobinary5()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.ToBinary(52);
            //Assert
            Assert.Equal("110100", z);
        }
    }
}
