using Calculator.Domain.Interfaces;

namespace Calculator.Domain.Operations
{
    public class Division : IOperation
    {
        public decimal Execute(decimal left, decimal right)
        {
            if (right == 0) throw new DivideByZeroException("Não é possível dividir por zero.");
            
            return left / right;
        }
    }
}