namespace Calculator.Generic
{
    public static class FactoryGenerics
    {
        //public static IOperand<T> GetSumGenericFactory<T>()
        //{
        //    return new GenericClass<T>();
        //}

        public static IOperation GetSubsGenericFactory()
        {
            return new GenericSubstract();
        }
    }
}
