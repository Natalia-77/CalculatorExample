using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal sealed class SquareRootOperation : BaseOperation, IOneOperandOperation
    {
        public SquareRootOperation() : base(OperationType.Square)
        {
        }
        public float GetResult(float singleOperand)
        {
            return singleOperand == 0 ? throw new ArgumentNullException(nameof(singleOperand), "Should be not null")
             : (float)Math.Sqrt((double)singleOperand);
        }
    }
}
