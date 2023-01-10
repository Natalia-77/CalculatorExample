using Calculator.BaseClass.ParseRomanNumber;

namespace Calculator.Generic
{
    public class RomanNumeric : BaseParseRomanNumber, IOperand<RomanNumeric>
    {
        private int _numerics;
        public RomanNumeric(int operandType)
        {
            _numerics = operandType;
        }
        public RomanNumeric()
        {
        }
        public int Numerics
        {
            get => _numerics;
            init => _numerics = value < 0 ? throw new ArgumentException("Operand should be positive", nameof(value)) : value;
        }
        public static RomanNumeric operator -(RomanNumeric left, RomanNumeric right)
        {
            var resultSubs = left.Numerics - right.Numerics;
            return new RomanNumeric(resultSubs);
        }
        public static RomanNumeric operator +(RomanNumeric left, RomanNumeric right)
        {
            var resultSum = left.Numerics + right.Numerics;
            return new RomanNumeric(resultSum);
        }
        public static RomanNumeric ParseStringToNumber(string inputStr)
        {
            var roman = new RomanNumeric().GetNumeric(inputStr);
            return new RomanNumeric(roman);
        }

    }
}
