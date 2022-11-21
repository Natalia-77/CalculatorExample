namespace Calculator.Generic.INumber
{
    public class IntOperandNumber : IOperandNumber<IntOperandNumber>
    {
        public int Val { get; }
        public IntOperandNumber(int val)
        {
            Val = val;
        }
        public static IntOperandNumber operator +(IntOperandNumber left, IntOperandNumber right)
        {
            return new IntOperandNumber(left.Val + right.Val);
        }

        public static IntOperandNumber operator -(IntOperandNumber left, IntOperandNumber right)
        {
            return new IntOperandNumber(left.Val - right.Val);
        }
    }
}
