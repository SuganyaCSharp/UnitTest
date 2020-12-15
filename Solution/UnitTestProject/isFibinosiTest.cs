using System;
using System.Collections.Generic;
using System.Text;
using solution;
using Xunit;

namespace UnitTestProject
{
    public class isFibinosiTest
    {
        [Fact]
        public void Isfibinosi()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.Isfibisonsi(2);
            //Assert
            Assert.True(z);
        }
        [Fact]
        public void Isfibinosi1()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.Isfibisonsi(34);
            //Assert
            Assert.True(z);
        }
        [Fact]
        public void Isfibinosi2()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.Isfibisonsi(56);
            //Assert
            Assert.False(z);
        }
        [Fact]
        public void Isfibinosi3()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.Isfibisonsi(125);
            //Assert
            Assert.False(z);
        }
        [Fact]
        public void Isfibinosi5()
        {
            //Arrange
            var solution = new Solution();
            //Act
            var z = solution.Isfibisonsi(13);
            //Assert
            Assert.True(z);
        }
    }
}
