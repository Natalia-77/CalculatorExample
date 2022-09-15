using CalculatorOperations.Interfaces;
using CalculatorOperations.Operations;
using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations
{
    public static class Factory
    {
        public static ITwoOperandsOperation SumTwoFactory()
        {
            return new SumOperation();
        }
        public static ITwoOperandsOperation SubtractFactory()
        {
            return new SubtractOperation();
        }
        public static IOneOperandOperation SquareRootFactory()
        {
            return new SquareRootOperation();
        }
        public static ITwoOperandsOperation DivideFactory()
        {
            return new DivideOperation();
        }
        public static IMultiOperandsOperation MultiOperandsFactory()
        {
            return new SumMultiOperation();
        }
        public static IOneOperandOperation ModuleFactory()
        {
            return new ModuleOperation();
        }
    }
}
