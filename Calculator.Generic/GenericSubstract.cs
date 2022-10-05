namespace Calculator.Generic
{
    public class GenericSubstract : IOperation
    {
        //public override T GetResultOperations<T>(IOperand<T>left, IOperand<T>right)
        // {
        //  Type type = left.GetType();
        //  Console.WriteLine($"Type {type}");
        //  //int capacity = operands.Length;
        //Console.WriteLine($"Capacity{capacity}");

        //IOperand<T>? res = default;


        // for (int i = 0; i < operands.Length; i++)
        //{
        // res = GetResultSubOperation(operands[ 0 ], operands[ 1 ]);
        // res = left.Subs(left,right);

        //Console.WriteLine($"Score{operands[ i ]}");
        // }
        //return res;
        // }

        public IOperand<T> GetResultSubOperation<T>(IOperand<T> first, IOperand<T> second)
        {
            IOperand<T>? res = default;
            res = first.Subs(second);
            return res;
        }

    }
}
