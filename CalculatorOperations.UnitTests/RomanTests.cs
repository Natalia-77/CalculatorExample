using Calculator.Generic;
using Calculator.Generic.INumber;

namespace CalculatorOperations.UnitTests
{
    public class RomanTests
    {
        [Theory]
        [InlineData("IV", 4)]
        public void CheckResultParseRomanToAradNumber(string roman, int arab)
        {
            var actual = RomanNumeric.ParseStringToNumber(roman);
            Assert.Equal(arab, actual.Numerics);
        }

        [Theory]
        [InlineData("IV", "4")]
        public void ShowRomanToAradNumber(string roman, string expected)
        {
            var parsedRomanNumeric = RomanNumericsNumber.Parse(roman, null);
            var parsedNumberToString = parsedRomanNumeric.ToString();
            Assert.Equal(expected, parsedNumberToString);
        }
    }
}
