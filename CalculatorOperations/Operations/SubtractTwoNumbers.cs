using CalculatorOperations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal class SubtractTwoNumbers : IDoubleValueOperands
    {
        public decimal Execute(decimal firstValue, decimal secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
