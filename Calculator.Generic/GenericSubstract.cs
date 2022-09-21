namespace Calculator.Generic
{
    public class GenericSubstract<T> : Operation<T>
    {
        private readonly Operation<T>? _operation;

        public  T GetResultOperations(T[ ] operands)
        {
            Type type = operands.GetType();
            Console.WriteLine($"Type {type}");
            int capacityQueue = operands.Length;
            Console.WriteLine($"Capacity{capacityQueue}");

            T? res = default(T);
            for (int i = 0; i < operands.Length; i++)
            {
                res = _operation.GetResultSubOperation(operands[ 0 ], operands[ 1 ]);
                Console.WriteLine($"Score{operands[ i ]}");
            }
            return res ?? default(T);
        }

        public override T GetResultSubOperation(T first, T second)
        {
            Type type = first.GetType();
            Console.WriteLine($"Type {type}");
            T? res = default(T);
            Console.WriteLine(first);
            res = _operation.GetResultSubOperation(first, second);
            return res ?? default(T);
        }
    }
}
