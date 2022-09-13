using System.CommandLine;
using CalculatorOperations;
using System.CommandLine.NamingConventionBinder;
using System.CommandLine.Parsing;
using Calculator.Console.UI;

namespace Calculator.UnitTests
{
    public class CalculateTests
    {
        //[Theory]
        //[InlineData(1, 0)]
        //public void CheckDivedeByZero(decimal first, decimal two)
        //{
        //    string expectedErrorMessage = "Attempted to divide by zero.";
        //    DivideByZeroException ex = Assert.Throws<DivideByZeroException>(() =>
        //   // Factory.GetDivideOperationFactory(first, two).GetOperation().GetResultDivideTwoArguments);
        //    Assert.Equal(expectedErrorMessage, ex.Message);
        //}

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
           // command.Handler = CommandHandler.Create(DoubleArgumentExpression.GetTwoAddArgumentsCommand);
            int resultOperation = result.Invoke();
            Assert.Equal(4, resultOperation);
        }

        [Theory]
        [InlineData("10 2", 8)]
        public void CheckValidSubtractArguments(string values, int resulrArgument)
        {
            var rootCommand = new RootCommand();
            var command = new Command("--subs")
            {
               new Argument<decimal>("first", "First argument "),
               new Argument<decimal>("second", "Second argument")
            };
            var result = new Parser(command).Parse(values);
            //command.Handler = CommandHandler.Create(DoubleArgumentExpression.GetTwoSubstractArgumentsCommand);
            int resultOperation = result.Invoke();
            bool isEqualResult = resultOperation.Equals(resulrArgument);
            Assert.True(isEqualResult);
        }

        [Theory]
        [InlineData("8 2", 4)]
        public void CheckValidDivideArguments(string values, int resulrArgument)
        {
            var rootCommand = new RootCommand();
            var command = new Command("--div")
            {
               new Argument<decimal>("first", "First argument "),
               new Argument<decimal>("second", "Second argument")
            };
            var result = new Parser(command).Parse(values);
           // command.Handler = CommandHandler.Create(DoubleArgumentExpression.GetDivideTwoArgumentsCommand);
            int resultOperation = result.Invoke();
            bool isEqualResult = resultOperation.Equals(resulrArgument);
            Assert.True(isEqualResult);
        }

        [Theory]
        [InlineData("2 p")]
        [InlineData("  s")]
        [InlineData("2 0")]
        [InlineData("   ")]
        public void CheckInValidDivideArguments(string values)
        {
            var command = new Command("--div")
            {
               new Argument<decimal>("first", "First argument "),
               new Argument<decimal>("second", "Second argument")
            };
            var result = new Parser(command).Parse(values);
            string? errorMessage = result.Errors.ToString();
            bool isErrorExist = false;
            if (errorMessage != null)
            {
                isErrorExist = true;
            }
            bool isExpectError = true;
            Assert.Equal(isExpectError, isErrorExist);
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
