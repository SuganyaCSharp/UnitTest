using solution;
using System;
using Xunit;

namespace UnitTestProject
{
    public class isprimetest
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var solution= new solution.Solution();
            //Act
            var z = solution.Isprime(2);
            //Assert
            Assert.True(z);
        }
        [Fact]
        public void Test2()
        {
            //Arrange
            var solution = new solution.Solution();
            //Act
            var z = solution.Isprime(15);
            //Assert
            Assert.False(z);
        }
        [Fact]
        public void Test3()
        {
            //Arrange
            var solution = new solution.Solution();
            //Act
            var z = solution.Isprime(120);
            //Assert
            Assert.False(z);
        }
        [Fact]
        public void Test4()
        {
            //Arrange
            var solution = new solution.Solution();
            //Act
            var z = solution.Isprime(361);
            //Assert
            Assert.False(z);
        }
        [Fact]
        public void Test5()
        {
            //Arrange
            var solution = new solution.Solution();
            //Act
            var z = solution.Isprime(19);
            //Assert
            Assert.True(z);
        }
    }
}
