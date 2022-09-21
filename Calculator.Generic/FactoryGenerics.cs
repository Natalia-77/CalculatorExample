namespace Calculator.Generic
{
    public static class FactoryGenerics
    {
        public static IOperand<T> GetSumGenericFactory<T>()
        {
            return new GenericClass<T>();
        }

        public static IOperation<T> GetSubsGenericFactory<T>()
        {
            return new GenericSubstract<T>();
        }
    }
}
