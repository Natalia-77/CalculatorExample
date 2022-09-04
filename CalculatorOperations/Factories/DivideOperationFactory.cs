using CalculatorOperations.Operations;

namespace CalculatorOperations.Factories
{
    public class DivideOperationFactory : OperationsFactory
    {
        private readonly decimal _firstOperand;
        private readonly decimal _secondOperand;
        public DivideOperationFactory(decimal first, decimal second)
        {
            _firstOperand = first;
            _secondOperand = second;
        }

        public override BaseOperation GetOperation()
        {
            return new DivideOperation(_firstOperand, _secondOperand);
        }
    }
}
