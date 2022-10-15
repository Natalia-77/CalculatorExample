namespace Calculator.Generic
{
    public class GenericSumOperation : IOperation
    {
        public IOperand<T> GetResultOperation<T>(IOperand<T> first, IOperand<T> second)
        {
            var res = first.Sum(second);
            return res;
        }

    }
}
