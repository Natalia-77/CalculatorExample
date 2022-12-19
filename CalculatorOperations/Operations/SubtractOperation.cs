using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal sealed class SubtractOperation : BaseOperation, ITwoOperandsOperation
    {
        public SubtractOperation() : base(OperationType.Substract)
        {
        }

        public float GetResult(float first, float second)
        {
            return first - second;
        }
    }
}
