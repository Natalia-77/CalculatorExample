using System.Collections.ObjectModel;
using System.Numerics;

namespace Calculator.Generic.INumber
{
    public class RomanNumericsNumber : IOperandNumber<RomanNumericsNumber>,
        IAdditionOperators<RomanNumericsNumber, RomanNumericsNumber, RomanNumericsNumber>
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

        public static RomanNumericsNumber ParseStringToNumber(string inputStr)
        {
            string strToParse = inputStr.ToUpper();
            if (string.IsNullOrEmpty(inputStr))
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
    }
}
