namespace CalculatorOperations.Operations
{
    internal class SumOperation : BaseOperation
    {
        public SumOperation(decimal first, decimal second) : base(OperationType.Sum)
        {
            FirstOperand = first;
            SecondOperand = second;
        }
    }
}
