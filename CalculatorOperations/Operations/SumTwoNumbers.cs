using CalculatorOperations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal class SumTwoNumbers : IDoubleValueOperands
    {
        public decimal Execute(decimal firstValue, decimal secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
