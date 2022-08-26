using CalculatorOperations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal class ModuleSingleNumber : ISingleValueOperand
    {
        public decimal Execute(decimal singleValue)
        {
            return Math.Abs(singleValue);
        }
    }
}
