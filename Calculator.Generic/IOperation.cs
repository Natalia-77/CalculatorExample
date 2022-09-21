namespace Calculator.Generic
{
    public interface IOperation<T>
    {
        T GetResultSubOperation(T first, T second);
    }
}
