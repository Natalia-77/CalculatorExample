using CalculatorOperations.Operations;

namespace CalculatorOperations.Factories
{
    public class SumMultiOperationFactory : OperationsFactory
    {
        public override BaseOperation GetOperation()
        {
            return new SumMultiOperation();
        }
    }
}
