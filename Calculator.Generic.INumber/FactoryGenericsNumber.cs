using System.Numerics;
namespace Calculator.Generic.INumber
{
    public static class FactoryGenericsNumber
    {
        public static T Sum<T>(T val, T val2) where T : INumber<T>
        {
            return val + val2;
        }
    }
}
