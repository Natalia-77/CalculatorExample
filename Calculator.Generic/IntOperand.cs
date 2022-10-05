namespace Calculator.Generic
{
    public class IntOperand : Operand<int>
    {

        public IntOperand(int operandType) : base(operandType)
        {
        }

        public override IOperand<int> Sum(IOperand<int> other)
        {

            throw new NotImplementedException();
        }

        public override IOperand<int> Divide(IOperand<int> other)
        {
            throw new NotImplementedException();
        }

        public override IOperand<int> Subs(IOperand<int> other)
        {
            return new IntOperand(Value - other.Value);
        }
    }
}
