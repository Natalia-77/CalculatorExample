namespace Calculator.Generic
{
    public abstract class Operation<T> 
    {
       
        public abstract IOperand<T> GetResultSubOperation(IOperand<T> first, IOperand<T> second);
       
    }
}
