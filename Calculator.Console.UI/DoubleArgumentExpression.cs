using System.CommandLine;
using CalculatorOperations;

namespace Calculator.Console.UI
{
    internal class DoubleArgumentExpression
    {
        public static Command GetTwoArgumentsCommand()
        {
            var firstArgument = new Argument<decimal>("first", "First argument ");
            var operation = new Argument<string>("operation", "Operation of expression");
            var secondArgument = new Argument<decimal>("second", "Second argument");           

            RootCommand rootCommand = new RootCommand();
            rootCommand.Add(firstArgument);          
            rootCommand.Add(operation);
            rootCommand.Add(secondArgument);

            rootCommand.SetHandler((firstArgumentValue, operationValue, secondArgumentValue) =>
            {

                CalculatorOperations.MathOperationsTypes.OperationTypes type = 0;

                switch (operationValue)
                {
                    case "+":
                        type = CalculatorOperations.MathOperationsTypes.OperationTypes.Sum;
                        break;
                    case "-":
                        type = CalculatorOperations.MathOperationsTypes.OperationTypes.Substrat;
                        break;
                    case "*":
                        type = CalculatorOperations.MathOperationsTypes.OperationTypes.Multiple;
                        break;                    
                    default:
                        type = 0;
                        break;
                }
                decimal res = Provider.DoubleExpression.GetMathExpression(firstArgumentValue, secondArgumentValue, type);
                System.Console.WriteLine($"Result: {res}");

            }, firstArgument, operation, secondArgument);
           
            return rootCommand;
        }
       
    }
}
