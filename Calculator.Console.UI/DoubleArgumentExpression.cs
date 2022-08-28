using CalculatorOperations;

namespace Calculator.Console.UI
{
    public static class DoubleArgumentExpression
    {
        public static int GetTwoArgumentsCommand(decimal first, decimal second)
        {
            int res = (int)Provider.DoubleExpression.GetMathExpression(first, second, CalculatorOperations.MathOperationsTypes.OperationTypes.Sum);
            System.Console.WriteLine($"Result--- operation: {res}");
            return res;
        }

    }
}
