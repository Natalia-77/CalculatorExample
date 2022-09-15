using CalculatorOperations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal class ModuleOperation : BaseOperation, IOneOperandOperation
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
