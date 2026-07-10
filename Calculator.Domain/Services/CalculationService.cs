using Calculator.Domain.Factories;
using Calculator.Domain.Models;

namespace Calculator.Domain.Services
{
    public class CalculationService
    {
        private readonly OperationFactory _operationFactory;

        public CalculationService()
        {
            _operationFactory = new OperationFactory();
        }

        public decimal Execute(CalculationState state)
        {
            if (!state.IsComplete)
                throw new InvalidOperationException("Operação incompleta. Faltam operandos ou operador.");

            var operation = _operationFactory.Create(state.Operator);
            return operation.Execute(state.LeftOperand, state.RightOperand);
        }

        public decimal ExecuteUnary(string operatorSymbol, decimal operand)
        {
            var operation = _operationFactory.CreateUnary(operatorSymbol);
            return operation.Execute(operand);
        }
    }
}
