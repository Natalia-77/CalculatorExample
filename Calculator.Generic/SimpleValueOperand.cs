namespace Calculator.Generic
{
    public class SimpleValueOperand<T> : IOperand<SimpleValueOperand<T>> where T : IOperand<T>
    {
        public T Value { get; init; }
        public SimpleValueOperand(T value)
        {
            Value = value;
        }

        public static SimpleValueOperand<T> operator +(SimpleValueOperand<T> left, SimpleValueOperand<T> right)
        {
            return new SimpleValueOperand<T>(left.Value + right.Value);
        }

        public static SimpleValueOperand<T> operator -(SimpleValueOperand<T> left, SimpleValueOperand<T> right)
        {
            return new SimpleValueOperand<T>(left.Value - right.Value);
        }
    }
}
