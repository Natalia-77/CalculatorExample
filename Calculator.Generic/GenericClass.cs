namespace Calculator.Generic
{
    public class GenericClass<T> : Operand<T>
    {

        public GenericClass() : base(Activator.CreateInstance<T>())
        {
            //_operation = new Operation<T>;
            //Value = Activator.CreateInstance<T>();

        }

        public override T GetResultOperation(T[ ] operands)
        {
            Type type = operands.GetType();
            Console.WriteLine($"Type {type}");
            int capacityQueue = operands.Length;
            Console.WriteLine($"Capacity{capacityQueue}");

            T? score = default(T);
            for (int i = 0; i < operands.Length; i++)
            {
                score += (dynamic)operands[ i ];
                Console.WriteLine($"Score{operands[ i ]}");
            }
            return score ?? default(T);
        }

    }
}
