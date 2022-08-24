
using CalculatorOperations.MathOperationsTypes;

namespace CalculatorOperations.CompleteMathExpressions.Interfaces
{
    public interface ISingleValueExpression
    {
        decimal GetMathExpression(decimal singleValue, OperationTypes operationsTypes);

    }
}
