// See https://aka.ms/new-console-template for more information
using System.CommandLine;
using System.Globalization;
using CalculatorOperations;

[assembly: CLSCompliant(true)]
namespace Calculator.Console.UI;

 class Program
{
    static async Task Main(string[ ] args)
    {
        
        //DoubleArgumentExpression.GetTwoArgumentsCommand().Invoke(args);

        // SingleArgumentExpression.GetOneArgumentsCommand().Invoke(args);        

        if (args.Length > 2)
        {
            DoubleArgumentExpression.GetTwoArgumentsCommand().Invoke(args);
        }
        else
        {
            SingleArgumentExpression.GetOneArgumentsCommand().Invoke(args);
        }
        //int choice = 0;
        //do
        //{
        //    choice = Show();

        //    //System.Console.Clear();
        //    if (choice == 1)
        //    {
        //        SingleArgumentExpression.GetOneArgumentsCommand().Invoke(args);
        //        System.Console.WriteLine($"1111111{choice}");
        //        //System.Console.ReadKey();

        //    }
        //}
        //while (choice != 3);


    }     

}

