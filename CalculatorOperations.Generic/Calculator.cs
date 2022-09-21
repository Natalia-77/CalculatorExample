namespace CalculatorOperations.Generic
{
    internal abstract class Calculator<T> : ICalculator<T>
    {
        public abstract T Divide(T first, T second);

        public abstract T Sum(T sum,T value);

    }
}
