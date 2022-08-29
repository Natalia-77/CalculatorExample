using System.CommandLine;
using CalculatorOperations;
using System.CommandLine.NamingConventionBinder;
using System.CommandLine.Parsing;
using Calculator.Console.UI;

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

        [Theory]
        [InlineData("2 2")]
        [InlineData("1 3")]
        public void CheckValidArguments(string values)
        {
            var rootCommand = new RootCommand();
            var command = new Command("--add")
            {
               new Argument<decimal>("first", "First argument "),
               new Argument<decimal>("second", "Second argument")
            };
            var result = new Parser(command).Parse(values);
            command.Handler = CommandHandler.Create(DoubleArgumentExpression.GetTwoAddArgumentsCommand);
            int resultOperation = result.Invoke();
            Assert.Equal(4, resultOperation);
        }

        [Theory]
        [InlineData("d 2")]
        [InlineData("1 p")]
        [InlineData("  p")]
        public void CheckInValidArguments(string values)
        {
            var command = new Command("--add")
            {
               new Argument<decimal>("first", "First argument "),
               new Argument<decimal>("second", "Second argument")
            };
            var result = new Parser(command).Parse(values);
            string? errorsMessage = result.Errors.ToString();
            bool isErrorExist = false;
            if (errorsMessage != null)
            {
                isErrorExist = true;
            }
            bool isExpectError = true;
            Assert.Equal(isExpectError, isErrorExist);
        }
    }
}
