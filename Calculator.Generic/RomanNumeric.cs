using Calculator.BaseClass.ParseRomanNumber;

namespace Calculator.Generic
{
    public class RomanNumeric : BaseParseRomanNumber, IOperand<RomanNumeric>
    {
        private int _numerics;
        private string _numberRoman;
        public RomanNumeric(int operandType)
        {
            _numerics = operandType;
            _numberRoman = string.Empty;
        }
        public RomanNumeric()
        {
            _numberRoman = string.Empty;
        }
        public int Numerics
        {
            get => _numerics;
            init => _numerics = value < 0 ? throw new ArgumentException("Operand should be positive", nameof(value)) : value;
        }
        public string NumberRoman
        {
            get
            {
                foreach (KeyValuePair<string, int> res in DictionaryValues)
                {
                    if (res.Value == Numerics)
                    {
                        _numberRoman = res.Key;
                    }
                }
                return _numberRoman;
            }
        }

        public override string ToString()
        {
            return NumberRoman;
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
