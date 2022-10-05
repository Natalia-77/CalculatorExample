namespace Calculator.Generic
{
    public abstract class Operation<T> : IOperation<T>
    {
       
        public abstract IOperand<T> GetResultSubOperation(IOperand<T> first,IOperand<T> second);
       
    }
}
