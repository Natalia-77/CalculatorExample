namespace Calculator.Generic
{
    public abstract class Operation<T> : IOperation<T>
    {
        public abstract T GetResultSubOperation(T first, T second);

    }
}
