using Calculator.Domain.Interfaces;

namespace Calculator.Domain.Operations.Unary
{
    public class Reciprocal : IUnaryOperation
    {
        public decimal Execute(decimal operand)
        {
            if (operand == 0)
                throw new DivideByZeroException("Não é possível calcular o recíproco de zero.");

            return 1 / operand;
        }
    }
}
