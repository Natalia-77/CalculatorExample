using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal sealed class ModuleOperation : BaseOperation, IOneOperandOperation
    {
        public ModuleOperation() : base(OperationType.Module)
        {
        }

        public float GetResult(float singleOperand)
        {
            return Math.Abs(singleOperand);
        }
    }
}
