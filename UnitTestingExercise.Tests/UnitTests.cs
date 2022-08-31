using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(0, 1, 2, 3)] //Add test data <-------
        [InlineData(2, 6, 7, 15)] //Add test data <-------
        [InlineData(-1, 0, -2, -3)] //Add test data <-------
        [InlineData(-10, 10, 5, 5)] //Add test data <-------

        //Arrange
        // create a Calculator object
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            var calculator = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1, 2, -1)]//Add test data <-------
        [InlineData(3, 2, 1)]//Add test data <-------
        [InlineData(0, 5, -5)]//Add test data <-------
        [InlineData(10, 6, 4)]//Add test data <-------
        [InlineData(2, 2, 0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange //Act //Assert
            var calculator = new Calculator();
            var actual = calculator.Subtract(minuend, subtrhend);
            Assert.Equal(expected, actual);
            

            

        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(3, 5, 15)]//Add test data <-------
        [InlineData(0, 1, 0)]//Add test data <-------
        [InlineData(3, -1, -3)]//Add test data <-------
        [InlineData(-5, -5, 25)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Multiply(num1, num2);
            Assert.Equal(expected, actual);

            //Start Step 7 here:

            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData(-1, -1, 1 )]//Add test data <-------
        [InlineData(2, 2, 1)]//Add test data <-------
        [InlineData(10, 2, 5)]//Add test data <-------
        [InlineData(-2, -2, 1)]//Add test data <-------
        [InlineData(15, -3, -5)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            var calcutor = new Calculator();
            var actual = calcutor.Divide(num1, num2);
            Assert.Equal(expected, actual);

            //Arrange

            //Act

            //Assert

        }

    }
}
