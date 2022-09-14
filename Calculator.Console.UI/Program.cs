// See https://aka.ms/new-console-template for more information
using System.CommandLine;
using System.Resources;
using System.CommandLine.Parsing;

[assembly: CLSCompliant(true)]
[assembly: NeutralResourcesLanguage("en")]
namespace Calculator.Console.UI;

class Program
{
    static int Main(string[ ] args)
    {
        var rootCommand = new RootCommand();
        var commandAdd = new Command("add")
        {
               new Argument<decimal>("first", "First argument "),
               new Argument<decimal>("second", "Second argument")
        };
        var commandSubs = new Command("subs")
        {
               new Argument<decimal>("first", "First argument "),
               new Argument<decimal>("second", "Second argument")
        };
        var arguments = new Argument<float[ ]>("operands")
        {
            Arity = new ArgumentArity(2, 3)
        };
        var argumentsDivide = new Argument<float[ ]>("divideOperands")
        {
            Arity = new ArgumentArity(2, 2)
        };
        var argumentModule = new Argument<float>("firstSingle", "Single argument");

        var commandMultiSum = new Command("mult")
        {
              arguments
        };
        var commandDivide = new Command("divide")
        {
            argumentsDivide
        };
        var commandModule = new Command("mod")
        {
            argumentModule

        };
        commandMultiSum.SetHandler(operands => DoubleArgumentExpression.GetSumMulti(operands), arguments);
        commandDivide.SetHandler(divideOperands => DoubleArgumentExpression.GetDivideTwoArgumentsCommand(divideOperands), argumentsDivide);
        commandModule.SetHandler(firstSingle => SingleArgumentExpression.GetSingleModuleArgumentsCommand(firstSingle), argumentModule);
        rootCommand.Add(commandAdd);
        rootCommand.Add(commandSubs);
        rootCommand.Add(commandMultiSum);
        rootCommand.Add(commandDivide);
        rootCommand.Add(commandModule);
        return rootCommand.Invoke(args);

    }
}

