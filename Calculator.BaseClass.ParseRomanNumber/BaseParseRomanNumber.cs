namespace Calculator.BaseClass.ParseRomanNumber
{
    public abstract class BaseParseRomanNumber
    {
        private readonly Dictionary<string, int> _dictionaryValues = new()
        {
            {"I",1 },
            {"V",5 },
            {"X",10 },
            {"L",50 },
            {"C",100 },
            {"D",500 },
            {"M",1000 }

        };
        public IReadOnlyDictionary<string, int> DictionaryValues => _dictionaryValues;
        public int GetNumeric(string strInput)
        {
            var strToParse = strInput.ToUpper();
            if (string.IsNullOrEmpty(strInput))
            {
                throw new ArgumentException("Enter valid roman number");
            }
            var resultArabicNumber = 0;
            var count = 0;
            var isNotExist = 0;
            var len = strToParse.Length;

            for (var i = 0; i <= len - 1; i++)
            {
                var isExist = DictionaryValues.TryGetValue(strToParse[i].ToString(), out var resValue);
                if (isExist)
                {
                    count++;
                    if (count < len)
                    {
                        var isNext = DictionaryValues.TryGetValue(strToParse[i + 1].ToString(), out var next);
                        if (isNext)
                        {
                            if (resValue < next)
                            {
                                var temp = next - resValue;
                                resultArabicNumber += temp;
                            }
                            else
                            {
                                resultArabicNumber += resValue;
                            }
                        }
                        else
                        {
                            resultArabicNumber += resValue;
                        }
                    }
                    else if (count == len)
                    {
                        if (resultArabicNumber < resValue && resultArabicNumber is not 0)
                        {
                            resultArabicNumber -= resValue;
                        }
                        resultArabicNumber += resValue;
                    }
                    else
                    {
                        resultArabicNumber += 0;
                    }
                }
                else
                {
                    count++;
                    isNotExist++;
                    resultArabicNumber += resValue;
                }
            }
            return isNotExist == count ? throw new ArgumentException("Enter valid roman number") : resultArabicNumber;
        }
    }
}
