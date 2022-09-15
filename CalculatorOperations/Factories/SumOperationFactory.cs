using CalculatorOperations.Operations;

namespace CalculatorOperations.Factories
{
    public class SumOperationFactory : OperationsFactory
    {
        public override BaseOperation GetOperation() => new SumOperation();

    }
}
