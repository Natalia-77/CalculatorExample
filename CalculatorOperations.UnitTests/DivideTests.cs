namespace CalculatorOperations.UnitTests
{
    public class DivideTests
    {
        [Theory]
        [InlineData(4, 2, 2)]
        public void CheckValidResult(float first, float second, float result)
        {
            var operation = Factory.DivideFactory();
            var actual = operation.GetResult(first, second);
            Assert.Equal(result, actual);
        }

        [Theory]
        [InlineData(new float[ ] { 2, 2, 5 }, 9)]
        [InlineData(new float[ ] { 5, 3, 6 }, 14)]
        public void CheckValidMultiSum(float[ ] numbers, float result)
        {
            var operation = Factory.MultiOperandsFactory();
            var actual = operation.GetResult(numbers);
            Assert.Equal(result, actual);
        }

    }
}
