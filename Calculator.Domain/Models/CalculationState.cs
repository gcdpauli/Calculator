namespace Calculator.Domain.Models
{
    public class CalculationState
    {
        public decimal LeftOperand { get; set; }
        public decimal RightOperand { get; set; }
        public string Operator { get; set; } = string.Empty;
        public bool HasLeftOperand { get; set; }
        public bool HasOperator { get; set; }
        public bool HasRightOperand { get; set; }

        public bool IsComplete => HasLeftOperand && HasOperator && HasRightOperand;

        public void Reset()
        {
            LeftOperand = 0;
            RightOperand = 0;
            Operator = string.Empty;
            HasLeftOperand = false;
            HasOperator = false;
            HasRightOperand = false;
        }
    }
}
