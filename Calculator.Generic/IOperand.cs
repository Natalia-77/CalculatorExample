namespace Calculator.Generic
{
    public interface IOperand<T>
    {
        T Value { get; }
        T GetResultOperation(T[ ] operands);
       
    }
}
