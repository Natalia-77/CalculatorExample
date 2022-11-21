using Calculator.Generic;
using Calculator.Generic.INumber;

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

        public static int GetSumArguments(string[ ] sumoperands)
        {
            if (sumoperands == null)
            {
                throw new ArgumentOutOfRangeException(nameof(sumoperands), "Should be not null.");
            }
            int[ ] parsedValues = new int[ sumoperands.Length ];
            int len = sumoperands.Length;
            for (int i = 0; i < sumoperands.Length; i++)
            {
                len--;
                if (int.TryParse(sumoperands[ i ], out parsedValues[ i ]))
                {

                    System.Console.WriteLine($"Len->{len}");
                    var firstOperand = parsedValues[ 0 ];
                    var secondOperand = parsedValues[ 1 ];
                    if (len == 0)
                    {
                        //var res = FactoryGenerics.OperationRes(new SimpleValueOperand<IntOperand>(new IntOperand(firstOperand)),
                        //    new SimpleValueOperand<IntOperand>(new IntOperand(secondOperand)));
                        //System.Console.Write($"{res.Value.Val} with type: {res.Value.GetType().Name}");
                        var res = FactoryGenericsNumber.Add(firstOperand,secondOperand);
                        System.Console.Write($"{res} with type: {res.GetType().Name}");
                    }
                }
                else
                {
                    var first = RomanNumeric.ParseStringToNumber(sumoperands[ 0 ]).Numerics;
                    var second = RomanNumeric.ParseStringToNumber(sumoperands[ 1 ]).Numerics;
                    RomanNumeric roman = new RomanNumeric(first);
                    RomanNumeric roman1 = new RomanNumeric(second);
                    if (len == 0)
                    {
                        var operationClassResult = FactoryGenerics.OperationRes(roman, roman1);
                        System.Console.Write($"{operationClassResult.Numerics} with type: {operationClassResult.GetType().Name}");
                    }
                }
            }
            return 0;
        }
    }
}
