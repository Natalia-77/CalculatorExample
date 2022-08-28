using System.CommandLine;
using CalculatorOperations;

namespace Calculator.UnitTests
{
    public class CalculateTests
    {
        [Fact]
        public void CheckDivedeByZero()
        {
            CalculatorOperations.MathOperationsTypes.OperationTypes type = (CalculatorOperations.MathOperationsTypes.OperationTypes)3;
            decimal num1 = 1;
            decimal num2 = 0;
            string expectedErrorMessage = "Divided by zero";
            ArithmeticException ex = Assert.Throws<ArithmeticException>(() =>
            Provider.DoubleExpression.GetMathExpression(num1, num2, type));
            Assert.Equal(expectedErrorMessage, ex.Message);
        }
        [Fact]
        public void By_default_there_is_no_default_value()
        {
            var command = new Command("--add");

        }
    }
}
