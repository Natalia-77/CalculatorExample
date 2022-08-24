using CalculatorOperations.Interfaces;

namespace CalculatorOperations.Operations
{
    public class SubtractTwoNumbers : IDoubleValueOperands
    {
        public decimal Execute(decimal firstValue, decimal secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
