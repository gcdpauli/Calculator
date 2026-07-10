using Calculator.Domain.Models;
using Calculator.Domain.Services;
using System.Globalization;

namespace Calculator.WinForms
{
    public partial class CalculatorForm : Form
    {
        private bool _isNewEntry = true;
        private readonly Dictionary<Keys, Action> _keyActions = new();
        private const float DefaultFontSize = 36f;
        private const int MaxDigitsBeforeResize = 10;
        private const int MaxCharacters = 16;

        private CalculationState _calculationState;
        private readonly CalculationService _calculationService;
        private string _currentOperator = string.Empty;

        public CalculatorForm()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += CalculatorForm_KeyDown;

            _calculationState = new CalculationState();
            _calculationService = new CalculationService();

            InitializeKeyMapping();
            SetupNumberButtonClicks();
            SetupOperatorButtons();
            SetupUnaryOperatorButtons();
            btnComma.MouseDown += (s, e) => HandleCommaInput();
            btnClear.MouseDown += (s, e) => HandleClearInput();
            btnBackSpace.MouseDown += (s, e) => HandleBackspaceInput();
            btnEqual.MouseDown += (s, e) => HandleEqualClick();
        }

        private void InitializeKeyMapping()
        {
            _keyActions[Keys.D0] = () => HandleDigitInput("0");
            _keyActions[Keys.D1] = () => HandleDigitInput("1");
            _keyActions[Keys.D2] = () => HandleDigitInput("2");
            _keyActions[Keys.D3] = () => HandleDigitInput("3");
            _keyActions[Keys.D4] = () => HandleDigitInput("4");
            _keyActions[Keys.D5] = () => HandleDigitInput("5");
            _keyActions[Keys.D6] = () => HandleDigitInput("6");
            _keyActions[Keys.D7] = () => HandleDigitInput("7");
            _keyActions[Keys.D8] = () => HandleDigitInput("8");
            _keyActions[Keys.D9] = () => HandleDigitInput("9");
            _keyActions[Keys.NumPad0] = () => HandleDigitInput("0");
            _keyActions[Keys.NumPad1] = () => HandleDigitInput("1");
            _keyActions[Keys.NumPad2] = () => HandleDigitInput("2");
            _keyActions[Keys.NumPad3] = () => HandleDigitInput("3");
            _keyActions[Keys.NumPad4] = () => HandleDigitInput("4");
            _keyActions[Keys.NumPad5] = () => HandleDigitInput("5");
            _keyActions[Keys.NumPad6] = () => HandleDigitInput("6");
            _keyActions[Keys.NumPad7] = () => HandleDigitInput("7");
            _keyActions[Keys.NumPad8] = () => HandleDigitInput("8");
            _keyActions[Keys.NumPad9] = () => HandleDigitInput("9");
            _keyActions[Keys.Decimal] = () => HandleCommaInput();
            _keyActions[Keys.Escape] = () => HandleClearInput();
            _keyActions[Keys.Back] = () => HandleBackspaceInput();
            _keyActions[Keys.Add] = () => HandleOperatorInput("+");
            _keyActions[Keys.Subtract] = () => HandleOperatorInput("-");
            _keyActions[Keys.Multiply] = () => HandleOperatorInput("*");
            _keyActions[Keys.Divide] = () => HandleOperatorInput("/");
            _keyActions[Keys.Enter] = () => HandleEqualClick();
        }

        private void SetupNumberButtonClicks()
        {
            btnZero.MouseDown += (s, e) => HandleDigitInput("0");
            btnOne.MouseDown += (s, e) => HandleDigitInput("1");
            btnTwo.MouseDown += (s, e) => HandleDigitInput("2");
            btnThree.MouseDown += (s, e) => HandleDigitInput("3");
            btnFour.MouseDown += (s, e) => HandleDigitInput("4");
            btnFive.MouseDown += (s, e) => HandleDigitInput("5");
            btnSix.MouseDown += (s, e) => HandleDigitInput("6");
            btnSeven.MouseDown += (s, e) => HandleDigitInput("7");
            btnEight.MouseDown += (s, e) => HandleDigitInput("8");
            btnNine.MouseDown += (s, e) => HandleDigitInput("9");
        }

        private void SetupOperatorButtons()
        {
            btnAddition.MouseDown += (s, e) => HandleOperatorInput("+");
            btnSubtraction.MouseDown += (s, e) => HandleOperatorInput("-");
            btnMultiplication.MouseDown += (s, e) => HandleOperatorInput("*");
            btnDivision.MouseDown += (s, e) => HandleOperatorInput("÷");
        }

        private void SetupUnaryOperatorButtons()
        {
            btnSquareRoot.MouseDown += (s, e) => HandleUnaryOperator("√");
            btnSquare.MouseDown += (s, e) => HandleBinaryExponentiation();
            btnReciprocal.MouseDown += (s, e) => HandleUnaryOperator("1/x");
            BtnPercent.MouseDown += (s, e) => HandleUnaryOperator("%");
            btnPlusMinus.MouseDown += (s, e) => HandleSignToggle();
        }

        private void HandleDigitInput(string digit)
        {
            if (_isNewEntry || txtResult.Text == "0")
            {
                txtResult.Text = digit;
                _isNewEntry = false;
            }
            else
            {
                if (GetDigitCount() < MaxCharacters)
                {
                    txtResult.Text += digit;
                }
                else
                {
                    return;
                }
            }
            FormatNumberWithThousandsSeparator();
            AdjustFontSize();
        }

        private void HandleCommaInput()
        {
            var decSep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (_isNewEntry)
            {
                txtResult.Text = "0" + decSep;
                _isNewEntry = false;
            }
            else if (!txtResult.Text.Contains(decSep))
            {
                txtResult.Text += decSep;
            }
            AdjustFontSize();
        }

        private void HandleBackspaceInput()
        {
            if (txtResult.Text.Length > 1)
            {
                txtResult.Text = txtResult.Text[..^1];
            }
            else
            {
                txtResult.Text = "0";
                _isNewEntry = true;
            }
            FormatNumberWithThousandsSeparator();
            AdjustFontSize();
        }

        private void HandleClearInput()
        {
            txtResult.Text = "0";
            txtLeftNumber.Text = "";
            lblOperator.Text = "";
            _isNewEntry = true;
            _currentOperator = string.Empty;
            _calculationState.Reset();
            AdjustFontSize();
        }

        private int GetDigitCount()
        {
            var decSep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string cleaned = txtResult.Text.Replace(".", "").Replace(",", "");
            return cleaned.Length;
        }

        private void FormatNumberWithThousandsSeparator()
        {
            var decSep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string text = txtResult.Text;

            if (!text.Contains(decSep))
            {
                string cleaned = text.Replace(".", "");
                string formatted = FormatIntegerPart(cleaned);
                txtResult.Text = formatted;
            }
            else
            {
                var parts = text.Split(decSep[0]);
                string integerPart = parts[0].Replace(".", "");
                string decimalPart = parts.Length > 1 ? parts[1] : "";

                string formattedInteger = FormatIntegerPart(integerPart);
                txtResult.Text = formattedInteger + decSep + decimalPart;
            }
        }

        private string FormatIntegerPart(string value)
        {
            if (value.Length <= 3)
                return value;

            string reversed = new string(value.Reverse().ToArray());
            string formatted = string.Empty;

            for (int i = 0; i < reversed.Length; i++)
            {
                if (i > 0 && i % 3 == 0)
                    formatted += ".";
                formatted += reversed[i];
            }

            return new string(formatted.Reverse().ToArray());
        }

        private void AdjustFontSize()
        {
            int digitCount = GetDigitCount();

            if (digitCount <= MaxDigitsBeforeResize)
            {
                txtResult.Font = new Font(txtResult.Font.FontFamily, DefaultFontSize, FontStyle.Bold);
                return;
            }

            float scaleFactor = (float)MaxDigitsBeforeResize / digitCount;
            float newSize = DefaultFontSize * scaleFactor;
            txtResult.Font = new Font(txtResult.Font.FontFamily, newSize, FontStyle.Bold);
        }

        private void CalculatorForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (_keyActions.TryGetValue(e.KeyCode, out var action))
            {
                action.Invoke();
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void HandleOperatorInput(string operatorSymbol)
        {
            string displaySymbol = operatorSymbol == "/" ? "÷" : operatorSymbol;

            if (string.IsNullOrEmpty(_currentOperator))
            {
                _calculationState.LeftOperand = GetDisplayValue();
                _calculationState.HasLeftOperand = true;
                _currentOperator = operatorSymbol;
                _calculationState.Operator = operatorSymbol;
                _calculationState.HasOperator = true;

                txtLeftNumber.Text = txtResult.Text;
                lblOperator.Text = displaySymbol;
                txtResult.Text = "0";
                _isNewEntry = true;
            }
            else if (!_calculationState.HasRightOperand)
            {
                _calculationState.RightOperand = GetDisplayValue();
                _calculationState.HasRightOperand = true;

                try
                {
                    decimal result = _calculationService.Execute(_calculationState);

                    _calculationState.Reset();
                    _calculationState.LeftOperand = result;
                    _calculationState.HasLeftOperand = true;
                    _currentOperator = operatorSymbol;
                    _calculationState.Operator = operatorSymbol;
                    _calculationState.HasOperator = true;

                    txtLeftNumber.Text = FormatNumberForDisplay(result);
                    lblOperator.Text = displaySymbol;
                    txtResult.Text = "0";
                    _isNewEntry = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Operação Inválida");
                    ResetCalculationState();
                }
            }
        }

        private string FormatNumberForDisplay(decimal value)
        {
            string text = value.ToString(CultureInfo.CurrentCulture);
            txtResult.Text = text;
            FormatNumberWithThousandsSeparator();
            return txtResult.Text;
        }

        private void HandleEqualClick()
        {
            if (string.IsNullOrEmpty(_currentOperator) || !_calculationState.HasLeftOperand)
                return;

            _calculationState.RightOperand = GetDisplayValue();
            _calculationState.HasRightOperand = true;

            try
            {
                if (_calculationState.IsComplete)
                {
                    decimal result = _calculationService.Execute(_calculationState);
                    DisplayResult(result);

                    txtLeftNumber.Text = "";
                    lblOperator.Text = "";
                    _currentOperator = string.Empty;

                    ResetCalculationState();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Operação Inválida");
                HandleClearInput();
            }
        }

        private decimal GetDisplayValue()
        {
            string text = txtResult.Text.Replace(".", "").Replace(",", "");
            var decSep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (txtResult.Text.Contains(decSep))
            {
                var parts = txtResult.Text.Split(decSep[0]);
                text = string.Concat(parts[0].Replace(".", ""), decSep, parts.Length > 1 ? parts[1] : "0");
            }

            return decimal.Parse(text, CultureInfo.CurrentCulture);
        }

        private void DisplayResult(decimal value)
        {
            txtResult.Text = value.ToString(CultureInfo.CurrentCulture);
            FormatNumberWithThousandsSeparator();
            AdjustFontSize();
        }

        private void ResetCalculationState()
        {
            _calculationState = new CalculationState();
            _isNewEntry = true;
            _currentOperator = string.Empty;
        }

        private void HandleUnaryOperator(string operatorSymbol)
        {
            try
            {
                decimal currentValue = GetDisplayValue();
                decimal result = _calculationService.ExecuteUnary(operatorSymbol, currentValue);
                DisplayResult(result);
                _isNewEntry = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Operação Inválida");
            }
        }

        private void HandleSignToggle()
        {
            try
            {
                decimal currentValue = GetDisplayValue();
                decimal result = -currentValue;
                DisplayResult(result);
                _isNewEntry = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Operação Inválida");
            }
        }

        private void HandleBinaryExponentiation()
        {
            if (string.IsNullOrEmpty(_currentOperator))
            {
                _calculationState.LeftOperand = GetDisplayValue();
                _calculationState.HasLeftOperand = true;
                _currentOperator = "^";
                _calculationState.Operator = "^";
                _calculationState.HasOperator = true;

                txtLeftNumber.Text = txtResult.Text;
                lblOperator.Text = "x²";
                txtResult.Text = "0";
                _isNewEntry = true;
            }
            else if (!_calculationState.HasRightOperand)
            {
                _calculationState.RightOperand = GetDisplayValue();
                _calculationState.HasRightOperand = true;

                try
                {
                    decimal result = _calculationService.Execute(_calculationState);

                    _calculationState.Reset();
                    _calculationState.LeftOperand = result;
                    _calculationState.HasLeftOperand = true;
                    _currentOperator = "^";
                    _calculationState.Operator = "^";
                    _calculationState.HasOperator = true;

                    txtLeftNumber.Text = FormatNumberForDisplay(result);
                    lblOperator.Text = "x²";
                    txtResult.Text = "0";
                    _isNewEntry = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Operação Inválida");
                    ResetCalculationState();
                }
            }
        }
    }
}