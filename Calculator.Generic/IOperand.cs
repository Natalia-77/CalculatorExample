﻿namespace Calculator.Generic
{
    public interface IOperand<T> where T : IOperand<T>
    {
        static abstract T operator +(T left, T right);
        static abstract T operator -(T left, T right);

    }
}
