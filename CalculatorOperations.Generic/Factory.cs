using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperations.Generic
{
    public static class Factory
    {
        public static T Getres<T>()
        {
            return new GenericClass<T>(new Calculator());
        }
    }
}
