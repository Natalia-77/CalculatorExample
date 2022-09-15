using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Interfaces
{
    public interface ITwoOperandsOperation : IOperation
    {
        float GetResult(float first, float second);

    }
}
