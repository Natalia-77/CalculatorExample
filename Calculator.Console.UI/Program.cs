// See https://aka.ms/new-console-template for more information
using System.CommandLine;
using System.Resources;
using System.CommandLine.NamingConventionBinder;

[assembly: CLSCompliant(true)]
[assembly: NeutralResourcesLanguage("en")]
namespace Calculator.Console.UI;

class Program
{
    static int Main(string[ ] args)
    {
        //var firstArgument = new Argument<decimal>("first", "First argument ");
        //var operation = new Argument<string>("operation", "Operation of expression");
        //var secondArgument = new Argument<decimal>("second", "Second argument");
        var rootCommand = new RootCommand();
        //rootCommand.Handler = CommandHandler.Create<decimal, string, decimal>(DoubleArgumentExpression.GetTwoArgumentsCommand);
        //rootCommand.Add(firstArgument);
        //rootCommand.Add(operation);
        //rootCommand.Add(secondArgument);
        //return rootCommand.Invoke(args);

        var command = new Command("--add")
        {
               new Argument<decimal>("first", "First argument "),
               new Argument<decimal>("second", "Second argument")
        };
        rootCommand.Add(command);
        //var subtractCommand = new Command("--sub");
        //var addCommand = new Command("--add");
        //rootCommand.Add(addCommand);
        //rootCommand.Add(subtractCommand);

        //var firstArgument = new Argument<decimal>("first", "First argument ");
        //var secondArgument = new Argument<decimal>("second", "Second argument");
        //rootCommand.Add(firstArgument);
        //rootCommand.Add(secondArgument);

        //addCommand.AddArgument(firstArgument);
        // addCommand.AddArgument(secondArgument);
        command.Handler = CommandHandler.Create<decimal, decimal>(DoubleArgumentExpression.GetTwoArgumentsCommand);
        return rootCommand.Invoke(args);

    }
}

