// See https://aka.ms/new-console-template for more information
using System.CommandLine;
using System.Resources;
using System.CommandLine.Parsing;

[assembly: CLSCompliant(true)]
[assembly: NeutralResourcesLanguage("en")]
namespace Calculator.Console.UI
{
    internal sealed class Program
    {
        private static int Main(string[] args)
        {
            var argumentsSum = new Argument<string[]>("sumoperands")
            {
                Arity = new ArgumentArity(2, 4)
            };
            var arguments = new Argument<float[]>("operands")
            {
                Arity = new ArgumentArity(2, 3)
            };
            var argumentsDivide = new Argument<float[]>("divideOperands")
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
            var commandSum = new Command("add")
            {
                argumentsSum

            };
            commandSum.SetHandler(sumoperands => DoubleArgumentExpression.GetSumArguments(sumoperands), argumentsSum);
            commandMultiSum.SetHandler(operands => DoubleArgumentExpression.GetSumMulti(operands), arguments);
            commandDivide.SetHandler(divideOperands => DoubleArgumentExpression.GetDivideTwoArgumentsCommand(divideOperands), argumentsDivide);
            commandModule.SetHandler(firstSingle => SingleArgumentExpression.GetSingleModuleArgumentsCommand(firstSingle), argumentModule);
            var rootCommand = new RootCommand
            {
               commandSum,
               commandMultiSum,
               commandDivide,
               commandModule
            };
            return rootCommand.Invoke(args);
        }
    }
}
