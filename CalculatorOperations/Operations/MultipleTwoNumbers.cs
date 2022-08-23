using CalculatorOperations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal class MultipleTwoNumbers : IDoubleValueOperands
    {
        public decimal Execute(decimal firstValue, decimal secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
