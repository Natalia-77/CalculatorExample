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
            return left == null || right == null ? throw new ArgumentNullException(nameof(left)) : new IntOperand(left.Val + right.Val);
        }

        public static IntOperand operator -(IntOperand left, IntOperand right)
        {
            return left == null || right == null ? throw new ArgumentNullException(nameof(left)) : new IntOperand(left.Val - right.Val);
        }

        public IntOperand Add(IntOperand left, IntOperand right)
        {
            return left == null || right == null ? throw new ArgumentNullException(nameof(left)) : new IntOperand(left.Val + right.Val);
        }

        public IntOperand Subtract(IntOperand left, IntOperand right)
        {
            return left == null || right == null ? throw new ArgumentNullException(nameof(left)) : new IntOperand(left.Val - right.Val);
        }
    }
}
