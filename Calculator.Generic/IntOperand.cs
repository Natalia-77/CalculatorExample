namespace Calculator.Generic
{
    public class IntOperand : IOperand<IntOperand>
    {
        public int Val { get; }
        public IntOperand(int val)
        {
            Val = val;
        }
        public static IntOperand operator +(IntOperand left, IntOperand right)
        {
            return new IntOperand(left.Val + right.Val);
        }

        public static IntOperand operator -(IntOperand left, IntOperand right)
        {
            return new IntOperand(left.Val - right.Val);
        }
    }
}
