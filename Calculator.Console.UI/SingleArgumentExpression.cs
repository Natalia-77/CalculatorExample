using CalculatorOperations;

namespace Calculator.Console.UI
{
    internal sealed class SingleArgumentExpression
    {
        public static int GetSingleModuleArgumentsCommand(float single)
        {
            var getModuleFactory = Factory.ModuleFactory();
            var resultOperation = getModuleFactory.GetResult(single);
            System.Console.WriteLine($"{resultOperation} with type: {getModuleFactory.Type}");
            return 0;
        }
    }
}
