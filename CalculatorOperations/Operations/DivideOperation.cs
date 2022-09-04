namespace CalculatorOperations.Operations
{
    internal class DivideOperation : BaseOperation
    {
        public DivideOperation(decimal first, decimal second) : base(OperationType.Divide)
        {
            FirstOperand = first;
            SecondOperand = second;
        }
    }
}
