using CalculatorOperations.Operations;

namespace CalculatorOperations.Factories
{
    public class SquareRootOperationFactory : OperationsFactory
    {
        private readonly decimal _firstSingleOperand;
        public SquareRootOperationFactory(decimal operand)
        {
            _firstSingleOperand = operand;
        }
        public override BaseOperation GetOperation()
        {
            return new SquareRootOperation(_firstSingleOperand);
        }
    }
}
