using System.Collections.ObjectModel;
using CalculatorOperations.Interfaces;
using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    public abstract class BaseOperation : ITwoOperandsOperation, IOneOperandsOperation, IMultiOperandsOperation
    {
        protected BaseOperation(OperationType type)
        {
            Type = type;
        }

        public OperationType Type { get; }
        public decimal FirstOperand { get; init; }
        public decimal SecondOperand { get; init; }
        public Collection<decimal>? MultiOperands { get; init; }
        public decimal GetResultSumTwoArguments => FirstOperand + SecondOperand;
        public decimal GetResultSubtractTwoArguments => FirstOperand - SecondOperand;
        public decimal GetResultDivideTwoArguments
        {
            get => FirstOperand / SecondOperand;
            init => SecondOperand = value.Equals(0) ? throw new DivideByZeroException("Attempted to divide by zero.") : value;
        }

        public decimal GetResultSquareOneArgument => (decimal)Math.Sqrt((double)FirstOperand);

        public decimal GetResultSumMultiArguments()
        {
            decimal res = 0;
            if (MultiOperands != null)
            {
                foreach (var item in MultiOperands)
                {
                    res += item;
                }
            }
            return res;
        }

        public decimal GetResultModuleOneArgument => Math.Abs(FirstOperand);
    }
}
