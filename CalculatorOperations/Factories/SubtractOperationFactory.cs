using CalculatorOperations.Operations;

namespace CalculatorOperations.Factories
{
    public class SubtractOperationFactory : OperationsFactory
    {
        public override BaseOperation GetOperation()
        {
            return new SubtractOperation();
        }

    }
}
