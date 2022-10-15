namespace CalculatorOperations.Generic
{
    public interface ICalculator<T>
    {
        T Sum(T[ ] values);
        T Divide(T first, T second);
    }
}
