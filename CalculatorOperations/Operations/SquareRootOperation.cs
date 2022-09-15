using CalculatorOperations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal class SquareRootOperation : BaseOperation, IOneOperandOperation
    {
        public SquareRootOperation() : base(OperationType.Square)
        {
        }

        public float GetResult(float singleOperand)
        {
            if (singleOperand == 0)
            {
                throw new ArgumentNullException(nameof(singleOperand), "Should be not null");
            }
            return (float)Math.Sqrt((double)singleOperand);
        }
    }
}
