using Calculator.Generic.INumber;

namespace Calculator.Console.UI
{
    public static class DoubleArgumentExpression
    {
        public static int GetSumTwo(float[] sumoperands)
        {
            CalculatorOperations.Operations.Interfaces.ITwoOperandsOperation getSumFactory = CalculatorOperations.Factory.SumTwoFactory();
            if (sumoperands == null)
            {
                throw new ArgumentOutOfRangeException(nameof(sumoperands), "Should be not null.");
            }
            var firstOperand = sumoperands[0];
            var secondOperand = sumoperands[1];
            var operationResult = getSumFactory.GetResult(firstOperand, secondOperand);
            System.Console.Write($"{operationResult} with type: {getSumFactory.Type}");
            return 0;
        }

        public static float GetSumMulti(float[] operands)
        {
            if (operands == null || operands.Length < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(operands), "Should contsist from 2 to 3 arguments");
            }
            CalculatorOperations.Operations.Interfaces.IMultiOperandsOperation getMultiSumFactory = CalculatorOperations.Factory.MultiOperandsFactory();
            var resultOperation = getMultiSumFactory.GetResult(operands);
            System.Console.Write($"{resultOperation} with type: {getMultiSumFactory.Type} ");
            return 0;//0-succ,1.2.3-error.
        }

        public static int GetDivideTwoArgumentsCommand(float[] divideOperands)
        {
            CalculatorOperations.Operations.Interfaces.ITwoOperandsOperation getDivideFactory = CalculatorOperations.Factory.DivideFactory();
            if (divideOperands == null)
            {
                throw new ArgumentOutOfRangeException(nameof(divideOperands), "Should be not null.");
            }
            var firstOperand = divideOperands[0];
            var secondOperand = divideOperands[1];
            var resultOperation = getDivideFactory.GetResult(firstOperand, secondOperand);
            System.Console.Write($"{resultOperation} with type: {getDivideFactory.Type} ");
            return 0;
        }

        public static int GetSumArguments(string[] sumoperands)
        {
            if (sumoperands == null)
            {
                throw new ArgumentOutOfRangeException(nameof(sumoperands), "Should be not null.");
            }
            var len = sumoperands.Length;
            var parsedValues = new int[len];

            for (var i = 0; i < len; i++)
            {
                if (sumoperands[i].isParsedValue<int>())
                {
                    var currentvalue = FactoryGenericsNumber.ParsedValue<int>(sumoperands[i]);
                    parsedValues[i] = currentvalue;
                }
                else
                {
                    RomanNumericsNumber currentvalue = FactoryGenericsNumber.ParsedValue<RomanNumericsNumber>(sumoperands[i]);
                    parsedValues[i] = currentvalue.Numerics;
                }
                if (parsedValues[parsedValues.Length - 1] is not 0)
                {
                    var result = FactoryGenericsNumber.Sum(parsedValues);
                    System.Console.WriteLine($"Result: {result}");
                }
            }
            return 0;
        }
    }
}
