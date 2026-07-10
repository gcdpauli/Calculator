using System.Globalization;
using System.Text.RegularExpressions;

namespace Calculator.WinForms
{
    public partial class CalculatorForm : Form
    {
        private bool _isNewEntry = true;
        private readonly Dictionary<Keys, Action> _keyActions = new();
        private const float DefaultFontSize = 36f;
        private const int MaxDigitsBeforeResize = 10;
        private const int MaxCharacters = 16;

        public CalculatorForm()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += CalculatorForm_KeyDown;

            InitializeKeyMapping();
            SetupNumberButtonClicks();
            btnComma.Click += (s, e) => HandleCommaInput();
            btnClear.Click += (s, e) => HandleClearInput();
            btnBackSpace.Click += (s, e) => HandleBackspaceInput();
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
        }

        private void SetupNumberButtonClicks()
        {
            btnZero.Click += (s, e) => HandleDigitInput("0");
            btnOne.Click += (s, e) => HandleDigitInput("1");
            btnTwo.Click += (s, e) => HandleDigitInput("2");
            btnThree.Click += (s, e) => HandleDigitInput("3");
            btnFour.Click += (s, e) => HandleDigitInput("4");
            btnFive.Click += (s, e) => HandleDigitInput("5");
            btnSix.Click += (s, e) => HandleDigitInput("6");
            btnSeven.Click += (s, e) => HandleDigitInput("7");
            btnEight.Click += (s, e) => HandleDigitInput("8");
            btnNine.Click += (s, e) => HandleDigitInput("9");
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
            _isNewEntry = true;
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
        }
    }
}