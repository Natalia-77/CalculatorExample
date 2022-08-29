using CalculatorOperations;

namespace Calculator.Console.UI
{
    public static class DoubleArgumentExpression
    {
        public static int GetTwoAddArgumentsCommand(decimal first, decimal second)
        {
            var type = CalculatorOperations.MathOperationsTypes.OperationTypes.Sum;
            int res = (int)Provider.DoubleExpression.GetMathExpression(first, second, type);
            System.Console.WriteLine($"Result operation: {res}");
            return res;
        }

        public static int GetTwoSubsArgumentsCommand(decimal first, decimal second)
        {
            var type = CalculatorOperations.MathOperationsTypes.OperationTypes.Substrat;
            int res = (int)Provider.DoubleExpression.GetMathExpression(first, second, type);
            System.Console.WriteLine($"Result operation: {res}");
            return res;
        }

    }
}
