using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Calculator.BaseClass.ParseRomanNumber;

namespace Calculator.Generic.INumber
{
    public class RomanNumericsNumber : BaseParseRomanNumber, IAdditionOperators<RomanNumericsNumber, RomanNumericsNumber, RomanNumericsNumber>, IParsable<RomanNumericsNumber>
    {
        private int _numerics;
        private string _numberRoman;
        public RomanNumericsNumber(int operandType)
        {
            _numerics = operandType;
            _numberRoman = string.Empty;

        }
        public RomanNumericsNumber()
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
        public static RomanNumericsNumber operator -(RomanNumericsNumber left, RomanNumericsNumber right)
        {
            var resultSubs = left.Numerics - right.Numerics;
            return new RomanNumericsNumber(resultSubs);
        }
        public static RomanNumericsNumber operator +(RomanNumericsNumber left, RomanNumericsNumber right)
        {
            var resultSum = left.Numerics + right.Numerics;
            return new RomanNumericsNumber(resultSum);
        }
        public static RomanNumericsNumber Parse(string s, IFormatProvider? provider)
        {
            var numberParsedResult = new RomanNumericsNumber().GetNumeric(s);
            return new RomanNumericsNumber(numberParsedResult);
        }
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out RomanNumericsNumber result)
        {
            result = null;
            if (s == null) { return false; }
            try
            {
                result = Parse(s, provider);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
