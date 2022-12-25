using System.Collections.ObjectModel;

namespace Calculator.Generic
{
    public class RomanNumeric : IOperand<RomanNumeric>
    {
        public static readonly IReadOnlyDictionary<string, int> dictionaryValues = new ReadOnlyDictionary<string, int>(new Dictionary<string, int>
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
        public RomanNumeric(int operandType)
        {
            _numerics = operandType;
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
            var strToParse = inputStr.ToUpper();
            if (string.IsNullOrEmpty(inputStr))
            {
                return new RomanNumeric(0);
            }
            var resultArabicNumber = 0;
            var count = 0;
            var len = strToParse.Length;
            for (var i = 0; i <= len - 1; i++)
            {
                var current = dictionaryValues[strToParse[i].ToString()];
                count++;
                if (count < len)
                {
                    var next = dictionaryValues[strToParse[i + 1].ToString()];
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
            return new RomanNumeric(resultArabicNumber);
        }

    }
}
