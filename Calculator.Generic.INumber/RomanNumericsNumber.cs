using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Calculator.Generic.INumber
{
    public class RomanNumericsNumber : IAdditionOperators<RomanNumericsNumber, RomanNumericsNumber, RomanNumericsNumber>,IParsable<RomanNumericsNumber>
    {
        public static readonly IReadOnlyDictionary<string, int> _dictionaryValues = new ReadOnlyDictionary<string, int>(new Dictionary<string, int>
        {
            {"I",1 },
            {"V",5 },
            {"X",10 },
            {"L",50 },
            {"C",100 },
            {"D",500 },
            {"M",1000 }

        });
        private int _numerics;
        public RomanNumericsNumber(int operandType)
        {
            _numerics = operandType;
        }
        public int Numerics
        {
            get => _numerics;
            init => _numerics = value < 0 ? throw new ArgumentException("Operand should be positive", nameof(value)) : value;
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
            string strToParse = s.ToUpper();
            if (string.IsNullOrEmpty(s))
            {
                return new RomanNumericsNumber(0);
            }
            int resultArabicNumber = 0;
            int count = 0;
            int len = strToParse.Length;
            for (int i = 0; i <= len - 1; i++)
            {
                var current = _dictionaryValues[ strToParse[ i ].ToString() ];
                count++;
                if (count < len)
                {
                    var next = _dictionaryValues[ strToParse[ i + 1 ].ToString() ];
                    if (current < next)
                    {
                        resultArabicNumber -= current;
                    }
                    else
                    {
                        resultArabicNumber += current;
                    }
                }
                else
                {
                    resultArabicNumber += current;
                }
            }
            return new RomanNumericsNumber(resultArabicNumber);
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
