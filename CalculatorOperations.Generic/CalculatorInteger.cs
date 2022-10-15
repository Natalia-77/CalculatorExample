namespace CalculatorOperations.Generic
{
    internal class Calculator : Calculator<int>
    {
        public override int Divide(int first, int second)
        {
            return first / second;
        }

        public override int Sum(int sum,int value)
        {
            return sum + value;
        }
    }
}
