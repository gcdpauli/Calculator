using Calculator.Domain.Interfaces;

namespace Calculator.Domain.Operations
{
    public class Addition : IOperation
    {
        public decimal Execute(decimal left, decimal right) => left + right;
    }
}