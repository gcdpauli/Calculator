using Calculator.Domain.Interfaces;
using Calculator.Domain.Operations;
using Calculator.Domain.Operations.Unary;

namespace Calculator.Domain.Factories
{
    public class OperationFactory
    {
        public IOperation Create(string operatorSymbol)
        {
            return operatorSymbol switch
            {
                "+" => new Addition(),
                "-" => new Subtraction(),
                "*" => new Multiplication(),
                "÷" => new Division(),
                "/" => new Division(),
                "^" => new Exponentiation(),
                _ => throw new ArgumentException($"Operador inválido: {operatorSymbol}")
            };
        }

        public IUnaryOperation CreateUnary(string operatorSymbol)
        {
            return operatorSymbol switch
            {
                "%" => new Percentage(),
                "√" => new SquareRoot(),
                "1/x" => new Reciprocal(),
                "+/-" => new Negate(),
                _ => throw new ArgumentException($"Operador unário inválido: {operatorSymbol}")
            };
        }
    }
}
