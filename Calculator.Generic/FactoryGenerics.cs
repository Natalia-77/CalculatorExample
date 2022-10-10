namespace Calculator.Generic
{
    public static class FactoryGenerics
    {
        public static IOperation GetSumGenericFactory()
        {
            return new GenericSumOperation();
        }
    }
}
