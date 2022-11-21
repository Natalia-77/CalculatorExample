using System.Numerics;

namespace Calculator.Generic.INumber
{
    public class SimpleValueOperandNumber<T> : IOperandNumber<SimpleValueOperandNumber<T>> where T : INumber<T>
    {
        public T Value { get; init; }
        public SimpleValueOperandNumber(T value)
        {
            Value = value;
        }

        public static SimpleValueOperandNumber<T> operator +(SimpleValueOperandNumber<T> left, SimpleValueOperandNumber<T> right)
        {
            return new SimpleValueOperandNumber<T>(left.Value + right.Value);
        }

        public static SimpleValueOperandNumber<T> operator -(SimpleValueOperandNumber<T> left, SimpleValueOperandNumber<T> right)
        {
            return new SimpleValueOperandNumber<T>(left.Value - right.Value);
        }
    }
}
