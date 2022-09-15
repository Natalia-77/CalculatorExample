using CalculatorOperations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal class SubtractOperation : BaseOperation, ITwoOperandsOperation
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
