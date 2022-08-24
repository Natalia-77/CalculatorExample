using CalculatorOperations.CompleteMathExpressions.Interfaces;
using CalculatorOperations.Interfaces;
using CalculatorOperations.MathOperationsTypes;
using CalculatorOperations.Operations;

namespace CalculatorOperations.CompleteMathExpressions
{
    public class SingleValueExpression : ISingleValueExpression
    {
        private ISingleValueOperand? _singleValue;
       
        public decimal GetMathExpression(decimal singleValue, OperationTypes operationsTypes)
        {
            decimal value;
            switch (operationsTypes)
            {
                case OperationTypes.Sum:
                    _singleValue = new SquareRootSingleNumber();
                    value = _singleValue.Execute(singleValue);
                    break;

                case OperationTypes.Substrat:
                    _singleValue = new ModuleSingleNumber();
                    value = _singleValue.Execute(singleValue);
                    break;

                default:
                    value = 0;
                    break;
            }

            return value;
        }
    }
}
