namespace Calculator.Generic
{
    public interface IOperand<T>
    {
        T Value { get; }
        IOperand<T> Sum(IOperand<T> other);
        IOperand<T> Subs(IOperand<T> other);
        IOperand<T> Divide(IOperand<T> other);

    }
}
