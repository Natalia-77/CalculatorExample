// See https://aka.ms/new-console-template for more information
using System.CommandLine;
using System.Resources;
using System.CommandLine.NamingConventionBinder;
using System.CommandLine.Parsing;

[assembly: CLSCompliant(true)]
[assembly: NeutralResourcesLanguage("en")]
namespace Calculator.Console.UI;

class Program
{
    static int Main(string[ ] args)
    {
        var rootCommand = new RootCommand();
        var commandAdd = new Command("--add")
        {
               new Argument<decimal>("first", "First argument "),
               new Argument<decimal>("second", "Second argument")
        };
        var commandSubs = new Command("--subs")
        {
               new Argument<decimal>("first", "First argument "),
               new Argument<decimal>("second", "Second argument")
        };
        var commandModule = new Command("--mod")
        {
            new Argument<decimal>("single", "Single argument ")
        };
        rootCommand.Add(commandAdd);
        rootCommand.Add(commandSubs);
        rootCommand.Add(commandModule);
        var result = new Parser(rootCommand).Parse(args);
        var command = result.CommandResult.Command;

        switch (command.Name)
        {
            case "--add":
                commandAdd.Handler = CommandHandler.Create<decimal, decimal>(DoubleArgumentExpression.GetTwoAddArgumentsCommand);
                break;
            case "--subs":
                commandSubs.Handler = CommandHandler.Create<decimal, decimal>(DoubleArgumentExpression.GetTwoSubsArgumentsCommand);
                break;
            case "--mod":
                commandModule.Handler = CommandHandler.Create<decimal>(SingleArgumentExpression.GetSingleModuleArgumentsCommand);
                break;
            default:
                break;
        }
        return rootCommand.Invoke(args);

    }
}

