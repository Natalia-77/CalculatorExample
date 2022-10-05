namespace Calculator.Generic
{
    public class RomanNumeric : IOperand<RomanNumeric>
    {
        //private string _numerics;
        public RomanNumeric(int operandType)
        {
            Numerics = operandType;
        }

        public RomanNumeric Value => this;
        public int Numerics
        {
            get => Numerics;
            init => Numerics = value < 0 ? throw new ArgumentException("Operand should be positive", nameof(value)) : value;

        }



        public IOperand<RomanNumeric> Divide(IOperand<RomanNumeric> other)
        {
            throw new NotImplementedException();
        }

        public IOperand<RomanNumeric> Subs(IOperand<RomanNumeric> other)
        {
            return new RomanNumeric(Value - other.Value);
        }

        public IOperand<RomanNumeric> Sum(IOperand<RomanNumeric> other)
        {
            throw new NotImplementedException();
        }

        public static RomanNumeric operator -(int res, RomanNumeric numeric)
        {
            return new RomanNumeric(res-numeric.Value);
        }
    }
}
