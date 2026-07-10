namespace Calculator.Domain.Interfaces
{
    public interface IUnaryOperation
    {
        decimal Execute(decimal operand);
    }
}
