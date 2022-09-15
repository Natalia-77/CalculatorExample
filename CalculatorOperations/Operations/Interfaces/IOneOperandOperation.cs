using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Interfaces
{
    public interface IOneOperandOperation : IOperation
    {
        float GetResult(float singleOperand);
    }
}
