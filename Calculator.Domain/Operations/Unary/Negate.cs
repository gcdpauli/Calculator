using Calculator.Domain.Interfaces;

namespace Calculator.Domain.Operations.Unary
{
    public class Negate : IUnaryOperation
    {
        public decimal Execute(decimal operand)
        {
            return -operand;
        }
    }
}
