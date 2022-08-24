
using CalculatorOperations.MathOperationsTypes;

namespace CalculatorOperations.CompleteMathExpressions.Interfaces
{
    public interface IDoubleValueExpression
    {
        decimal GetMathExpression(decimal firstValue,decimal secondValue, OperationTypes operationsTypes);
    }
}
