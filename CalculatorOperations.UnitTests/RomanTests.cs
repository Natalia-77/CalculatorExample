using Calculator.Generic;
using Calculator.Generic.INumber;
//using Calculator.Generic.INumber;

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
        public void ShowRomanNumericToAradNumber(string roman, string expectedResult)
        {
            var parsedRomanNumeric = RomanNumeric.ParseStringToNumber(roman);
            var actualResult = parsedRomanNumeric.ToString();
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("V", "V")]
        public void ShowRomanToAradNumber(string roman, string expectedResult)
        {
            var parsedRomanNumeric = RomanNumericsNumber.Parse(roman, null);
            var actualResult = parsedRomanNumeric.ToString();
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("test")]
        public void ParseArabToNumberInputInvalidAtringThrowsArgumentException(string input)
        {
            var expectedErrorMessage = "Enter valid roman number";
            ArgumentException ex = Assert.Throws<ArgumentException>(() => RomanNumericsNumber.Parse(input, null));
            Assert.Equal(expectedErrorMessage, ex.Message);
        }

        [Theory]
        [InlineData("VstI", 6)]
        public void ParseArabToNumberArgumentException(string input, int parsedRes)
        {
            var parsedRomanNumeric = RomanNumericsNumber.Parse(input, null);
            //var actualResult = parsedRomanNumeric.ToString();
            Assert.Equal(parsedRes, parsedRomanNumeric.Numerics);
        }

    }
}
