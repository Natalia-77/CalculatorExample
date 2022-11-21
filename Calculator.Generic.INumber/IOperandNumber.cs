namespace Calculator.Generic.INumber
{
    public interface IOperandNumber<T> where T : IOperandNumber<T>
    {
        static abstract T operator +(T left, T right);
        static abstract T operator -(T left, T right);

    }
}
