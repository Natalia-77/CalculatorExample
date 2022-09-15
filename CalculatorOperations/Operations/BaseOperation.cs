using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    public abstract class BaseOperation : IOperation
    {
        protected BaseOperation(OperationType type)
        {
            Type = type;
        }

        public OperationType Type { get; }
    }
}
