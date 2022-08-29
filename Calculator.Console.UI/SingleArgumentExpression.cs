using CalculatorOperations;

namespace Calculator.Console.UI
{
    internal class SingleArgumentExpression
    {
        public static int GetSingleModuleArgumentsCommand(decimal single)
        {
            var type = CalculatorOperations.MathOperationsTypes.OperationTypes.Module;
            int res = (int)Provider.SingleExpression.GetMathExpression(single, type);
            System.Console.WriteLine($"Result operation: {res}");
            return res;
        }
    }
}
