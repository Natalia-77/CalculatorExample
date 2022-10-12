using Calculator.Generic;

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
    }
}
