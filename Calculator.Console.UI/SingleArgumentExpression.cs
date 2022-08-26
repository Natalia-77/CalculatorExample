using System.CommandLine;
using CalculatorOperations;

namespace Calculator.Console.UI
{
    internal class SingleArgumentExpression
    {
        public static Command GetOneArgumentsCommand()
        {
            var singleArgument = new Argument<decimal>("single", "Single argument");
            var operation = new Argument<string>("operation", "Operation of expression");
            RootCommand rootCommand = new RootCommand();
            rootCommand.Add(singleArgument);
            rootCommand.Add(operation);

            rootCommand.SetHandler((singleArgumentValue, operationValue) =>
            {
                try
                {
                    CalculatorOperations.MathOperationsTypes.OperationTypes type = 0;
                    decimal res = 0;
                    switch (operationValue)
                    {
                        case "@":
                            type = CalculatorOperations.MathOperationsTypes.OperationTypes.Module;
                            break;
                        //I had no time for searching symbol.Thats why I choose this one #.
                        case "#":
                            type = CalculatorOperations.MathOperationsTypes.OperationTypes.Square;
                            break;
                        default:
                            type = 0;
                            break;
                    }

                    res = Provider.SingleExpression.GetMathExpression(singleArgumentValue, type);
                    System.Console.WriteLine($"Result one argument: {res}");
                }
                catch (Exception)
                {
                    throw;
                }

            }, singleArgument, operation);

            return rootCommand;
        }
    }
}
