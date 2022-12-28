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
            var len = strToParse.Length;
            for (var i = 0; i <= len - 1; i++)
            {
                var isExist = DictionaryValues.ContainsKey(strToParse[i].ToString());
                if (isExist)
                {
                    var current = _dictionaryValues[strToParse[i].ToString()];
                    count++;
                    if (count < len)
                    {
                        var next = _dictionaryValues[strToParse[i + 1].ToString()];
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
                else
                {
                    throw new ArgumentException("Enter valid roman number");
                }
            }
            return resultArabicNumber;
        }
    }
}
