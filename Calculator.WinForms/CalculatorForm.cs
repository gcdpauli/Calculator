using System.Globalization;

namespace Calculator.WinForms
{
    public partial class CalculatorForm : Form
    {
        private bool _isNewEntry = true;
        private readonly Dictionary<Keys, Action> _keyActions = new();

        public CalculatorForm()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += CalculatorForm_KeyDown;

            InitializeKeyMapping();
            SetupNumberButtonClicks();
            btnComma.Click += (s, e) => HandleCommaInput();
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
            _keyActions[Keys.Oemcomma] = () => HandleCommaInput();
            _keyActions[Keys.Decimal] = () => HandleCommaInput();
            _keyActions[Keys.OemPeriod] = () => HandleCommaInput();
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
                return;
            }
            txtResult.Text += digit;
        }

        private void HandleCommaInput()
        {
            var decSep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (_isNewEntry)
            {
                txtResult.Text = "0" + decSep;
                _isNewEntry = false;
                return;
            }
            if (!txtResult.Text.Contains(decSep))
                txtResult.Text += decSep;
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