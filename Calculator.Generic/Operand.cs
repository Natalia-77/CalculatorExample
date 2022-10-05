namespace Calculator.Generic
{
    public abstract class Operand<T> : IOperand<T>
    {
        public virtual T Value { get; init; }
        public Operand(T operandType)
        {
            Value = operandType;
        }
        // public abstract T GetResultOperation(T[ ] operands);
        public abstract IOperand<T> Sum(IOperand<T> other);
        public abstract IOperand<T> Divide(IOperand<T> other);
        public abstract IOperand<T> Subs(IOperand<T> other);
    }
}
