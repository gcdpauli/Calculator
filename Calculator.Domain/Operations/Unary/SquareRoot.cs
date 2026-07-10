using Calculator.Domain.Interfaces;

namespace Calculator.Domain.Operations.Unary
{
    public class SquareRoot : IUnaryOperation
    {
        public decimal Execute(decimal operand)
        {
            if (operand < 0)
                throw new ArgumentException("Não é possível calcular a raiz quadrada de um número negativo.");

            return (decimal)Math.Sqrt((double)operand);
        }
    }
}
