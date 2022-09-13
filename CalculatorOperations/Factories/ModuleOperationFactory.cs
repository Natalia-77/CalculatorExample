using CalculatorOperations.Operations;

namespace CalculatorOperations.Factories
{

    public class ModuleOperationFactory : OperationsFactory
    {
        public override BaseOperation GetOperation()
        {
            return new ModuleOperation();
        }
    }
}
