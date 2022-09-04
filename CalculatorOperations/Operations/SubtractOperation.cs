namespace CalculatorOperations.Operations
{
    internal class SubtractOperation : BaseOperation
    {
        public SubtractOperation(decimal first, decimal second) : base(OperationType.Substract)
        {
            FirstOperand = first;
            SecondOperand = second;
        }
    }
}
