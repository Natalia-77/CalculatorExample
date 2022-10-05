namespace Calculator.Generic
{
    public interface IOperand<T>
    {
        T Value { get; }
        //T GetResultOperation(T[ ] operands);
        IOperand<T> Sum(IOperand<T> other);
        IOperand<T> Subs(IOperand<T> other);
        IOperand<T> Divide(IOperand<T> other);

    }
}
