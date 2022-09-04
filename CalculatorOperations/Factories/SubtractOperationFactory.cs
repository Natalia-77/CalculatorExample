using CalculatorOperations.Operations;

namespace CalculatorOperations.Factories
{
    public class SubtractOperationFactory : OperationsFactory
    {
        private readonly decimal _firstOperand;
        private readonly decimal _secondOperand;
        public SubtractOperationFactory(decimal first, decimal second)
        {
            _firstOperand = first;
            _secondOperand = second;
        }
        public override BaseOperation GetOperation() => new SubtractOperation(_firstOperand, _secondOperand);

    }
}
