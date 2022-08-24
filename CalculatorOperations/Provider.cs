using CalculatorOperations.CompleteMathExpressions;
using CalculatorOperations.CompleteMathExpressions.Interfaces;

[assembly: CLSCompliant(true)]
namespace CalculatorOperations
{
    public static class Provider
    {
        public static  IDoubleValueExpression DoubleExpression => new DoubleValueExpression();
        public static  ISingleValueExpression SingleExpression => new SingleValueExpression();
    }
}
