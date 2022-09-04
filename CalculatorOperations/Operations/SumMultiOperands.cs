using System.Collections.ObjectModel;

namespace CalculatorOperations.Operations
{
    internal class SumMultiOperands : BaseOperation
    {
        public SumMultiOperands(Collection<decimal> multiOperands) : base(OperationType.Sum)
        {
            MultiOperands = multiOperands;
        }
    }
}
