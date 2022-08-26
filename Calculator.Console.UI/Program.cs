// See https://aka.ms/new-console-template for more information
using System.CommandLine;
using System.Resources;
[assembly: CLSCompliant(true)]
[assembly: NeutralResourcesLanguage("en")]
namespace Calculator.Console.UI;

class Program
{
    static Task Main(string[ ] args)
    {
        string? input;
        do
        {
            System.Console.WriteLine(CommandTitlesResourse.MainTitle);
            System.Console.WriteLine(CommandTitlesResourse.MainTitleSecond);
            System.Console.WriteLine(CommandTitlesResourse.MainTitleExit);
            System.Console.Write(CommandTitlesResourse.Choice);
            input = System.Console.ReadLine();

            if (input == "1" || input == "2")
            {
                if (input == "1")
                {
                    System.Console.WriteLine(CommandTitlesResourse.FirstArgs);
                    var arg1 = System.Console.ReadLine();
                    System.Console.WriteLine(CommandTitlesResourse.SecondArgs);
                    var arg2 = System.Console.ReadLine();
                    if (arg1 != null && arg2 != null)
                    {
                        args = new string[ ] { arg1, arg2 };
                    }
                    SingleArgumentExpression.GetOneArgumentsCommand().Invoke(args);
                }
                else
                {
                    System.Console.WriteLine(CommandTitlesResourse.FirstArgs);
                    var arg1 = System.Console.ReadLine();
                    System.Console.WriteLine(CommandTitlesResourse.SecondArgs);
                    var arg2 = System.Console.ReadLine();
                    System.Console.WriteLine(CommandTitlesResourse.ThirdArgs);
                    var arg3 = System.Console.ReadLine();
                    if (arg1 != null && arg2 != null && arg3 != null)
                    {
                        args = new string[ ] { arg1, arg2, arg3 };
                    }
                    DoubleArgumentExpression.GetTwoArgumentsCommand().Invoke(args);
                }
            }
        }
        while (input != "3");
        return Task.CompletedTask;
    }
}

