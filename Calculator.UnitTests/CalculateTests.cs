using System.CommandLine;
using System.CommandLine.Parsing;

namespace Calculator.UnitTests
{
    public class CalculateTests
    {
        [Theory]
        [InlineData("2 p")]
        [InlineData("  s")]
        [InlineData("2 0")]
        [InlineData("   ")]
        public void CheckInValidDivideArguments(string values)
        {
            var command = new Command("divide")
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
            var command = new Command("add")
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
