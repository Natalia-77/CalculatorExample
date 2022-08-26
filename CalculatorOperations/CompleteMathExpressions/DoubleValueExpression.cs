using CalculatorOperations.CompleteMathExpressions.Interfaces;
using CalculatorOperations.Interfaces;
using CalculatorOperations.MathOperationsTypes;
using CalculatorOperations.Operations;

namespace CalculatorOperations.CompleteMathExpressions
{
    public class DoubleValueExpression : IDoubleValueExpression
    {
        private IDoubleValueOperands? _doubleValue;

        public decimal GetMathExpression(decimal firstValue, decimal secondValue, OperationTypes operationsTypes)
        {
            decimal value;
            switch (operationsTypes)
            {
                case OperationTypes.Sum:
                    _doubleValue = new SumTwoNumbers();
                    value = _doubleValue.Execute(firstValue, secondValue);
                    break;

                case OperationTypes.Substrat:
                    _doubleValue = new SubtractTwoNumbers();
                    value = _doubleValue.Execute(firstValue, secondValue);
                    break;

                case OperationTypes.Multiple:
                    _doubleValue = new MultipleTwoNumbers();
                    value = _doubleValue.Execute(firstValue, secondValue);
                    break;

                default:
                    value = 0;
                    break;
            }

            return value;
        }
    }
}
