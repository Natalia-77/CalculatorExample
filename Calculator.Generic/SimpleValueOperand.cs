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
            return left == null || right == null ? throw new ArgumentNullException(nameof(left)) : new SimpleValueOperand<T>(left.Value + right.Value);

        }

        public static SimpleValueOperand<T> operator -(SimpleValueOperand<T> left, SimpleValueOperand<T> right)
        {
            return left == null || right == null ? throw new ArgumentNullException(nameof(left)) : new SimpleValueOperand<T>(left.Value - right.Value);
        }

        public SimpleValueOperand<T> Add(SimpleValueOperand<T> left, SimpleValueOperand<T> right)
        {
            return left == null || right == null ? throw new ArgumentNullException(nameof(left)) : new SimpleValueOperand<T>(left.Value + right.Value);
        }

        public SimpleValueOperand<T> Subtract(SimpleValueOperand<T> left, SimpleValueOperand<T> right)
        {
            return left == null || right == null ? throw new ArgumentNullException(nameof(left)) : new SimpleValueOperand<T>(left.Value - right.Value);
        }
    }
}
