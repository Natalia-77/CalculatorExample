using CalculatorOperations.Operations.Interfaces;

namespace CalculatorOperations.Operations
{
    internal class SumMultiOperation : BaseOperation, IMultiOperandsOperation
    {
        public SumMultiOperation() : base(OperationType.Sum)
        {

        }

        public float GetResult(float[ ] numbers)
        {
            int capacityQueue = numbers.Length;
            Queue<float> queueArguments = new Queue<float>(capacityQueue);

            for (int i = 0; i < capacityQueue; i++)
            {
                queueArguments.Enqueue(numbers[ i ]);
            }
            if (queueArguments.Count == 0)
            {
                throw new ArgumentException("The queue can't be empty.");
            }
            if (queueArguments.Count > 0)
            {
                float res = queueArguments.Sum();
                ShowExpression(queueArguments);
                return res;
            }
            return 0;
        }

        public void ShowExpression(Queue<float> items)
        {
            var count = items.Count;
            //Console.WriteLine($"Count of queue :{count} ");
            Console.Write(ResourceFile.Expression);
            foreach (var item in items)
            {
                Console.Write(item);
                if (count > 1)
                {
                    Console.Write(ResourceFile.PlusSymbol);
                }
                if (count == 1)
                {
                    Console.Write(ResourceFile.EqualSymbol);
                }
                count--;
            }
        }
    }
}
