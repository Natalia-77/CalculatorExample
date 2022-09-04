using CalculatorOperations;

namespace Calculator.Console.UI
{
    public static class DoubleArgumentExpression
    {
        public static int GetTwoAddArgumentsCommand(decimal first, decimal second)
        {
            var getSumFactory = Factory.GetSumTwoOperandFactory(first, second);
            var operation = getSumFactory.GetOperation();
            var resultOperation = operation.GetResultSumTwoArguments;
            System.Console.WriteLine($"Result operation: {resultOperation} with type: {operation.Type}");
            return (int)resultOperation;
        }
        public static int GetTwoSubstractArgumentsCommand(decimal first, decimal second)
        {
            var getSubtractFactory = Factory.GetSubtractTwoOperandFactory(first, second);
            var operation = getSubtractFactory.GetOperation();
            var resultOperation = operation.GetResultSubtractTwoArguments;
            System.Console.WriteLine($"Result operation: {resultOperation} with type: {operation.Type}");
            return (int)resultOperation;
        }
        public static int GetDivideTwoArgumentsCommand(decimal first, decimal second)
        {
            var getDivideFactory = Factory.GetDivideOperationFactory(first, second);
            var operation = getDivideFactory.GetOperation();
            var resultOperation = operation.GetResultDivideTwoArguments;
            System.Console.WriteLine($"Result operation: {resultOperation} with type: {operation.Type} ");
            return (int)resultOperation;
        }
    }
}
