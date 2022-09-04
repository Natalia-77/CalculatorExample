using CalculatorOperations.Operations;

namespace CalculatorOperations.Factories
{
    public class SumOperationFactory : OperationsFactory
    {
        private readonly decimal _firstOperand;
        private readonly decimal _secondOperand;
        public SumOperationFactory(decimal first, decimal second)
        {
            _firstOperand = first;
            _secondOperand = second;
        }
        public override BaseOperation GetOperation() => new SumOperation(_firstOperand, _secondOperand);

    }
}
