namespace Calculator.Generic
{
    public class OperationInt : Operation<int>
    {
        public override int GetResultSubOperation(int first, int second)
        {
            return first - second;
        }

    }
}
