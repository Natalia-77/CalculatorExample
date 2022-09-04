using CalculatorOperations.Factories;

namespace CalculatorOperations
{
    public static class Factory
    {
        public static SumOperationFactory GetSumTwoOperandFactory(decimal first, decimal second)
        {
            return new SumOperationFactory(first, second);
        }
        public static SubtractOperationFactory GetSubtractTwoOperandFactory(decimal first, decimal second)
        {
            return new SubtractOperationFactory(first, second);
        }
        public static SquareRootOperationFactory GetSquareRootOperationFactory(decimal operand)
        {
            return new SquareRootOperationFactory(operand);
        }
        public static DivideOperationFactory GetDivideOperationFactory(decimal first, decimal second)
        {
            return new DivideOperationFactory(first, second);
        }
        public static ModuleOperationFactory GetModuleOperationFactory(decimal operand)
        {
            return new ModuleOperationFactory(operand);
        }
    }
}
