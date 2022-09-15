using CalculatorOperations.Operations;

[assembly: CLSCompliant(true)]
namespace CalculatorOperations.Factories
{
    public abstract class OperationsFactory
    {
        public abstract BaseOperation GetOperation();
    }
}
