namespace CalculatorOperations.Operations.Interfaces
{
    public interface IMultiOperandsOperation : IOperation
    {
        float GetResult(float[ ] numbers);
        void ShowExpression(Queue<float> items);
    }
}
