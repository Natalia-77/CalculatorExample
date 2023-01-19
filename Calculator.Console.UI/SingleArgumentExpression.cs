using CalculatorOperations;

namespace Calculator.Console.UI
{
    internal static class SingleArgumentExpression
    {
        public static int GetSingleModuleArgumentsCommand(float single)
        {
            CalculatorOperations.Operations.Interfaces.IOneOperandOperation getModuleFactory = Factory.ModuleFactory();
            var resultOperation = getModuleFactory.GetResult(single);
            System.Console.WriteLine($"{resultOperation} with type: {getModuleFactory.Type}");
            return 0;
        }
    }
}
