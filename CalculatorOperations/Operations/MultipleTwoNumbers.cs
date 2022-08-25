using CalculatorOperations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal class MultipleTwoNumbers : IDoubleValueOperands
    {
        public decimal Execute(decimal firstValue, decimal secondValue)
        {
            if (secondValue == 0)
                throw new ArithmeticException("Divided by zero");
            return firstValue / secondValue;
        }
    }
}
