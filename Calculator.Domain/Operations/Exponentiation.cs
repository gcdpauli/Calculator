using Calculator.Domain.Interfaces;

namespace Calculator.Domain.Operations
{
    public class Exponentiation : IOperation
    {
        public decimal Execute(decimal left, decimal right)
        {
            if (right < 0 && left != 0)
            {
                decimal result = 1 / (decimal)Math.Pow((double)left, (double)Math.Abs(right));
                return result;
            }

            return (decimal)Math.Pow((double)left, (double)right);
        }
    }
}
