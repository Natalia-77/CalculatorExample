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
            ParseResult result = new Parser(command).Parse(values);
            var errorMessage = result.Errors.ToString();
            var isErrorExist = false;
            if (errorMessage != null)
            {
                isErrorExist = true;
            }
            var isExpectError = true;
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
            ParseResult result = new Parser(command).Parse(values);
            var errorsMessage = result.Errors.ToString();
            var isErrorExist = false;
            if (errorsMessage != null)
            {
                isErrorExist = true;
            }
            var isExpectError = true;
            Assert.Equal(isExpectError, isErrorExist);
        }
    }
}
