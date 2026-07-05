namespace Calculator.Domain.Interfaces
{
    public interface IOperation
    {
        decimal Execute(decimal left, decimal right);
    }
}