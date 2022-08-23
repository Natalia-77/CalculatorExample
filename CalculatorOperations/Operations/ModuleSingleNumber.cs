using CalculatorOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperations.Operations
{
    internal class ModuleSingleNumber : ISingleValueOperand
    {
        public decimal Execute(decimal singleValue)
        {
            return Math.Abs(singleValue);
        }
    }
}
