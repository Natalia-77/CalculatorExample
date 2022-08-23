
using CalculatorOperations.MathOperationsTypes;

namespace CalculatorOperations.CompleteMathExpressions.Interfaces
{
    internal interface IDoubleValueExpression
    {
        decimal GetMathExpression(decimal firstValue,decimal secondValue, OperationTypes operationsTypes);
    }
}
