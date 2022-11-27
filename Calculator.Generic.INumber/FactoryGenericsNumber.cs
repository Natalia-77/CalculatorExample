using System.Numerics;
namespace Calculator.Generic.INumber
{
    public static class FactoryGenericsNumber
    {
        public static T Sum<T>(IEnumerable<T> values) where T : INumber<T>
        {
            T sum = T.Zero;
            foreach (var item in values)
            {
                sum += item;
            }
            return sum;
        }

        public static bool isParsedValue<T>(this string s) where T : IParsable<T>
        {
            return T.TryParse(s, null, out T? result);
        }

        public static T ParsedValue<T>(string s) where T : IParsable<T>
        {
            return T.Parse(s, null);
        }
    }
}
