using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Calculation_ShouldAddTwoNumbers()
        {
            // Arrange
            double Expected = 10;

            // Act
            double Actual = Calculation.Add(7, 3);

            // Assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void Calculation_ShouldSubtractTwoNumbers()
        {
            // Arrange
            double Expected = 10;

            // Act
            double Actual = Calculation.Substract(13, 3);

            // Assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void Calculation_ShouldMultiplyTwoNumbers()
        {
            // Arrange
            double Expected = 10;

            // Act
            double Actual = Calculation.Multiply(5, 2);

            // Assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void Calculation_ShouldDivideTwoNumbers()
        {
            // Arrange
            double Expected = 10;

            // Act
            double Actual = Calculation.Divide(20, 2);

            // Assert
            Assert.Equal(Expected, Actual);
        }
    }
}
