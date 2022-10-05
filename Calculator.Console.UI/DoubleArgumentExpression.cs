using Calculator.Generic;
using CalculatorOperations;

namespace Calculator.Console.UI
{
    public static class DoubleArgumentExpression
    {
        public static int GetSumTwo(float[ ] sumoperands)
        {
            var getSumFactory = CalculatorOperations.Factory.SumTwoFactory();
            if (sumoperands == null)
            {
                throw new ArgumentOutOfRangeException(nameof(sumoperands), "Should be not null.");
            }
            var firstOperand = sumoperands[ 0 ];
            var secondOperand = sumoperands[ 1 ];
            var operationResult = getSumFactory.GetResult(firstOperand, secondOperand);
            System.Console.Write($"{operationResult} with type: {getSumFactory.Type}");
            return 0;
        }

        public static float GetSumMulti(float[ ] operands)
        {
            if (operands == null || operands.Length < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(operands), "Should contsist from 2 to 3 arguments");
            }
            var getMultiSumFactory = CalculatorOperations.Factory.MultiOperandsFactory();
            var resultOperation = getMultiSumFactory.GetResult(operands);
            System.Console.Write($"{resultOperation} with type: {getMultiSumFactory.Type} ");
            return 0;//0-succ,1.2.3-error.
        }

        public static int GetDivideTwoArgumentsCommand(float[ ] divideOperands)
        {
            var getDivideFactory = CalculatorOperations.Factory.DivideFactory();
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

        public static int GetSubs(string[ ] str)
        {
            var getSumFactory = FactoryGenerics.GetSubsGenericFactory();
            if (sumoperands == null)
            {
                throw new ArgumentOutOfRangeException(nameof(sumoperands), "Should be not null.");
            }
            var firstOperand = sumoperands[ 0 ];
            var secondOperand = sumoperands[ 1 ];
            var result1 = new IntOperand(firstOperand);
            var result2 = new IntOperand(secondOperand);
            var operationResult = getSumFactory.GetResultSubOperation(result1, result2);
            System.Console.Write($"{operationResult.Value} with type: {getSumFactory.GetType()}");
            return 0;
        }
    }
}
