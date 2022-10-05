namespace Calculator.Generic
{
    public interface IOperation 
    {
        IOperand<T> GetResultSubOperation<T>(IOperand<T> first, IOperand<T> second);
    }
}
