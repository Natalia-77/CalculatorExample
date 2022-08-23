
using CalculatorOperations.MathOperationsTypes;

namespace CalculatorOperations.CompleteMathExpressions.Interfaces
{
    internal interface ISingleValueExpression
    {
        decimal GetMathExpression(decimal singleValue, OperationTypes operationsTypes);

    }
}
