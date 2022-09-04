namespace CalculatorOperations.Operations
{
    internal class ModuleOperation : BaseOperation
    {
        public ModuleOperation(decimal first) : base(OperationType.Module)
        {
            FirstOperand = first;
        }
    }
}
