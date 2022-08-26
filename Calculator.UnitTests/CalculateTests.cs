using System.CommandLine;
using Calculator.Console.UI;
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
        public void CheckConsoleInput()
        {
            string param1 = "2";
            string param2 = "+";
            string param3 = "2";
            //Return int,but why...there is only invoke and returns Command.
            _ = DoubleArgumentExpression.GetTwoArgumentsCommand().Invoke(new string[ ] { param1, param2, param3 });
            // TODO...
            //How I should re-write here for pass my test. Or where I can read about it.

        }
    }
}
