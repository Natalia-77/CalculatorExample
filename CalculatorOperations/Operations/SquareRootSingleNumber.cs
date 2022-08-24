using CalculatorOperations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal class SquareRootSingleNumber : ISingleValueOperand
    {
        public decimal Execute(decimal singleValue)
        {
            return (decimal)Math.Sqrt((double)singleValue);
        }
    }
}
