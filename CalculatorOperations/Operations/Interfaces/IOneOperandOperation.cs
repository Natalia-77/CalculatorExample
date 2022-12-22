namespace CalculatorOperations.Operations.Interfaces
{
    public interface IOneOperandOperation : IOperation
    {
        float GetResult(float singleOperand);
    }
}
