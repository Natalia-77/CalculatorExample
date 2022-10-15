namespace Calculator.Generic
{
    public interface IOperation
    {
        IOperand<T> GetResultOperation<T>(IOperand<T> first, IOperand<T> second);
    }
}
