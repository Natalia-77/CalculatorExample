using CalculatorOperations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal class SumOperation : BaseOperation, ITwoOperandsOperation
    {
        public SumOperation() : base(OperationType.Sum)
        {
        }

        public float GetResult(float first, float second)
        {
            return first + second;
        }
    }
}
