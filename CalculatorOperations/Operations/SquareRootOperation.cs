namespace CalculatorOperations.Operations
{
    internal class SquareRootOperation : BaseOperation
    {
        public SquareRootOperation(decimal first) : base(OperationType.Square)
        {
            FirstOperand = first;
        }
    }
}
