using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal sealed class DivideOperation : BaseOperation, ITwoOperandsOperation
    {
        public DivideOperation() : base(OperationType.Divide)
        {
        }

        public float GetResult(float first, float second)
        {
            if (second == 0)
            {
                throw new DivideByZeroException("Attempted to divide by zero.");
            }
            ShowExpression(first, second);
            return first / second;
        }

        public static void ShowExpression(float first, float second)
        {
            Console.Write($"{ResourceFile.Expression}{first}/{second} = ");
        }
    }
}
