using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperations.Generic
{
    internal class GenericClass<T>
    {
       private readonly Calculator<T> _calculator;
        public GenericClass(Calculator<T> calculator)
        {
            _calculator = calculator;
        }
        public T Sum(T[ ] values)
        {
            T? sum = default(T);
            for (int i = 0; i < values.Length; i++)
            {
                sum = _calculator.Sum(sum, values[ i ]);
            }

            return sum;
        }
    }
}
