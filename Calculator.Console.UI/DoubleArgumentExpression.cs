using CalculatorOperations;

namespace Calculator.Console.UI
{
    public static class DoubleArgumentExpression
    {
        //public static int GetTwoAddArgumentsCommand(decimal first, decimal second)
        //{
        //    var getSumFactory = Factory.GetSumTwoOperandFactory(first, second);
        //    var operation = getSumFactory.GetOperation();
        //    var resultOperation = operation.GetResultSumTwoArguments;
        //    System.Console.WriteLine($"Result operation: {resultOperation} with type: {operation.Type}");
        //    return (int)resultOperation;
        //}
        //public static int GetTwoSubstractArgumentsCommand(decimal first, decimal second)
        //{
        //    var getSubtractFactory = Factory.GetSubtractTwoOperandFactory(first, second);
        //    var operation = getSubtractFactory.GetOperation();
        //    var resultOperation = operation.GetResultSubtractTwoArguments;
        //    System.Console.WriteLine($"Result operation: {resultOperation} with type: {operation.Type}");
        //    return (int)resultOperation;
        //}


        public static float GetSumMulti(float[ ] operands)
        {
            if (operands == null || operands.Length < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(operands), "Should contsist from 2 to 3 arguments");
            }
            var getMultiSumFactory = Factory.MultiOperandsFactory();
            var resultOperation = getMultiSumFactory.GetResult(operands);
            System.Console.Write($"{resultOperation} with type: {getMultiSumFactory.Type} ");
            return 0;//0-succ,1.2.3-error.
        }

        public static int GetDivideTwoArgumentsCommand(float[ ] divideOperands)
        {
            var getDivideFactory = Factory.DivideFactory();
            if (divideOperands == null)
            {
                throw new ArgumentOutOfRangeException(nameof(divideOperands), "Should be not null.");
            }
            var firstOperand = divideOperands[ 0 ];
            var secondOperand = divideOperands[ 1 ];
            var resultOperation = getDivideFactory.GetResult(firstOperand, secondOperand);
            System.Console.Write($"{resultOperation} with type: {getDivideFactory.Type} ");
            return 0;
        }
    }
}
