using System.Numerics;

namespace Calculator.Generic
{
    public static class FactoryGenerics
    {
        public static T OperationRes<T>(T val, T val2) where T : IOperand<T>
        {
            return val + val2;
        }
        public static T Add<T>(T val, T val2) where T : INumber<T>
        {
            return val + val2;
        }
    }


}
