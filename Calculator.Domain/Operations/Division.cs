using Calculator.Domain.Interfaces;

namespace Calculator.Domain.Operations
{
    public class Division : IOperation
    {
        public decimal Execute(decimal left, decimal right)
        {
            if (right == 0) throw new DivideByZeroException("Cannot divide by zero.");
            
            return left / right;
        }
    }
}