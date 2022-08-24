// See https://aka.ms/new-console-template for more information
using System.CommandLine;
using System.Linq;
using System.Text.RegularExpressions;
using CalculatorOperations;

[assembly: CLSCompliant(true)]
namespace Calculator.Console.UI;

 class Program
{
    static async Task Main(string[ ] args)
    {
        var startOption = new Option<string>("--start", description: "Enter username:");
        var endOption = new Option<string>("--end", description: "Cancel,bye...");

        var firstArgument = new Argument<decimal> ("first", "First argument ");
        var operation = new Argument<string>("operation", "Operation of expression");
        var secondArgument = new Argument<decimal>("second", "Second argument");

        RootCommand rootCommand = new RootCommand();
        rootCommand.Add(firstArgument);
        rootCommand.Add(operation);
        rootCommand.Add(secondArgument);
        rootCommand.Add(startOption);
        rootCommand.Add(endOption);
      
        rootCommand.SetHandler((startOptionValue) =>
        {
            System.Console.WriteLine($"Hello, {startOptionValue}");
        }, startOption);

        rootCommand.SetHandler((endOptionValue) =>
        {
            System.Console.WriteLine("Bye...");
           
        }, endOption);

        rootCommand.SetHandler((firstArgumentValue, operationValue, secondArgumentValue) =>
        {
            //System.Console.WriteLine($"first argument = {firstArgumentValue}");
            //System.Console.WriteLine($"second argument = {secondArgumentValue}");

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
                case "||":
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
            decimal res = Provider.DoubleExpression.GetMathExpression(firstArgumentValue, secondArgumentValue, type);
            System.Console.WriteLine($"Result: {res}");
        },
            firstArgument, operation, secondArgument);

        foreach (var item in args)
        {
            System.Console.WriteLine(item);

        }

        _ = rootCommand.InvokeAsync(args);




    }   


}

