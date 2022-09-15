using CalculatorOperations.Operations;

namespace CalculatorOperations.Factories
{
    public class SquareRootOperationFactory : OperationsFactory
    {
        public override BaseOperation GetOperation()
        {
            return new SquareRootOperation();
        }
    }
}
