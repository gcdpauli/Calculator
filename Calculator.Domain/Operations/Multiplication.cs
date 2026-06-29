using Calculator.Domain.Interfaces;

namespace Calculator.Domain.Operations
{
    public class Multiplication : IOperation
    {
        public decimal Execute(decimal left, decimal right) => left * right;
    }
}
