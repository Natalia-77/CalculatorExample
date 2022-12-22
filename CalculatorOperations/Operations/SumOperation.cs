using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal sealed class SumOperation : BaseOperation, ITwoOperandsOperation
    {
        public SumOperation() : base(OperationType.Sum)
        {
        }

        public float GetResult(float first, float second)
        {
            ShowExpression(first, second);
            return first + second;
        }

        public static void ShowExpression(float first, float second)
        {
            Console.Write($"{first}{ResourceFile.PlusSymbol}{second}{ResourceFile.EqualSymbol}");
        }
    }
}
