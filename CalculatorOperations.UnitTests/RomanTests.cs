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
        [InlineData("V", "V")]
        public void ShowRomanToAradNumber(string roman, string expectedResult)
        {
            string res = string.Empty;
            var parsedRomanNumeric = RomanNumericsNumber.Parse(roman, null);
            parsedRomanNumeric.NumberRoman = res;
            var actualResult = parsedRomanNumeric.ToString();
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
