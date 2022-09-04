using CalculatorOperations.Operations;

namespace CalculatorOperations.Factories
{

    public class ModuleOperationFactory : OperationsFactory
    {
        private readonly decimal _firstSingleOperand;
        public ModuleOperationFactory(decimal operand)
        {
            _firstSingleOperand = operand;
        }
        public override BaseOperation GetOperation()
        {
            return new ModuleOperation(_firstSingleOperand);
        }
    }
}
