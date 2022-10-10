using Calculator.Generic;
using CalculatorOperations;

namespace Calculator.Console.UI
{
    public static class DoubleArgumentExpression
    {
        //public static int GetSumTwo(float[ ] sumoperands)
        //{
        //    var getSumFactory = CalculatorOperations.Factory.SumTwoFactory();
        //    if (sumoperands == null)
        //    {
        //        throw new ArgumentOutOfRangeException(nameof(sumoperands), "Should be not null.");
        //    }
        //    var firstOperand = sumoperands[ 0 ];
        //    var secondOperand = sumoperands[ 1 ];
        //    var operationResult = getSumFactory.GetResult(firstOperand, secondOperand);
        //    System.Console.Write($"{operationResult} with type: {getSumFactory.Type}");
        //    return 0;
        //}

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

        public static int GetSumArguments(string[ ] sumoperands)
        {
            var getGenericSumFactory = FactoryGenerics.GetSumGenericFactory();
            if (sumoperands == null)
            {
                throw new ArgumentOutOfRangeException(nameof(sumoperands), "Should be not null.");
            }
           // int[ ] parsedValues = new int[ sumoperands.Length ];
           // Type type = sumoperands.GetType();

            //if (type.Equals(typeof(int)))
            //{
            //for (int i = 0; i < sumoperands.Length; i++)
            //{
            //    if (Int32.TryParse(sumoperands[ i ], out parsedValues[ i ]))
            //    {
            //        System.Console.WriteLine(sumoperands[ i ]);
            //    }
            //    else
            //    {

            //    }
            //}
            //}

            //var firstOperand = parsedValues[ 0 ];
            //var secondOperand = parsedValues[ 1 ];
            //var result1 = new IntOperand(firstOperand);
            //var result2 = new IntOperand(secondOperand);
            //var operationResult = getGenericSumFactory.GetResultOperation(result1, result2);
            var res3 = RomanNumeric.ParseStringToNumber(sumoperands[ 0 ]);
            var res4 = RomanNumeric.ParseStringToNumber(sumoperands[ 1 ]);
            var opee = getGenericSumFactory.GetResultOperation(res3, res4);
            System.Console.Write($"{opee.Value.Numerics} with type: {opee.GetType()}");
            return 0;
        }
    }
}
