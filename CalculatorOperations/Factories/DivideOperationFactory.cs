using CalculatorOperations.Operations;

namespace CalculatorOperations.Factories
{
    public class DivideOperationFactory : OperationsFactory
    {
        public override BaseOperation GetOperation()
        {
            return new DivideOperation();
        }
    }
}
