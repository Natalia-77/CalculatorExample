using CalculatorOperations;

namespace Calculator.Console.UI
{
    internal class SingleArgumentExpression
    {
        public static int GetSingleModuleArgumentsCommand(float single)
        {
            var getModuleFactory = Factory.ModuleFactory();
            var resultOperation = getModuleFactory.GetResult(single);
            //var resultOperation = operation.GetResultModuleOneArgument;
            System.Console.WriteLine($"{resultOperation} with type: {getModuleFactory.Type}");
            return 0;
        }
    }
}
