using Calculator.Domain.Interfaces;

namespace Calculator.Domain.Operations.Unary
{
    public class Percentage : IUnaryOperation
    {
        public decimal Execute(decimal operand)
        {
            return operand / 100;
        }
    }
}
