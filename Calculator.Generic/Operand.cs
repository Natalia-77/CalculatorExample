namespace Calculator.Generic
{
    public abstract class Operand<T> : IOperand<T>
    {
        public virtual T Value { get; init; }
        public Operand(T operandType)
        {
            Value = operandType;
        }
        public abstract T GetResultOperation(T[ ] operands);
    }
}
