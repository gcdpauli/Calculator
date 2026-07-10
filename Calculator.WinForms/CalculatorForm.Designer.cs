namespace Calculator.WinForms
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Calculator = new ReaLTaiizor.Forms.SpaceForm();
            txtLeftNumber = new ReaLTaiizor.Controls.CrownTextBox();
            lblOperator = new Label();
            txtResult = new ReaLTaiizor.Controls.CrownTextBox();
            lblMemoryView = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            lblMemoryStore = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            lblMemorySubtract = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            lblMemoryAdd = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            lblMemoryRecall = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            lblMemoryClear = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            btnEqual = new ReaLTaiizor.Controls.SpaceButton();
            btnComma = new ReaLTaiizor.Controls.SpaceButton();
            btnZero = new ReaLTaiizor.Controls.SpaceButton();
            btnPlusMinus = new ReaLTaiizor.Controls.SpaceButton();
            btnAddition = new ReaLTaiizor.Controls.SpaceButton();
            btnThree = new ReaLTaiizor.Controls.SpaceButton();
            btnTwo = new ReaLTaiizor.Controls.SpaceButton();
            btnOne = new ReaLTaiizor.Controls.SpaceButton();
            btnSubtraction = new ReaLTaiizor.Controls.SpaceButton();
            btnSix = new ReaLTaiizor.Controls.SpaceButton();
            btnFive = new ReaLTaiizor.Controls.SpaceButton();
            btnFour = new ReaLTaiizor.Controls.SpaceButton();
            btnMultiplication = new ReaLTaiizor.Controls.SpaceButton();
            btnNine = new ReaLTaiizor.Controls.SpaceButton();
            btnEight = new ReaLTaiizor.Controls.SpaceButton();
            btnSeven = new ReaLTaiizor.Controls.SpaceButton();
            btnDivision = new ReaLTaiizor.Controls.SpaceButton();
            btnSquareRoot = new ReaLTaiizor.Controls.SpaceButton();
            btnSquare = new ReaLTaiizor.Controls.SpaceButton();
            btnReciprocal = new ReaLTaiizor.Controls.SpaceButton();
            btnBackSpace = new ReaLTaiizor.Controls.SpaceButton();
            btnClear = new ReaLTaiizor.Controls.SpaceButton();
            btnClearEntry = new ReaLTaiizor.Controls.SpaceButton();
            BtnPercent = new ReaLTaiizor.Controls.SpaceButton();
            btnClose = new ReaLTaiizor.Controls.SpaceClose();
            Calculator.SuspendLayout();
            SuspendLayout();
            // 
            // Calculator
            // 
            Calculator.BackColor = Color.FromArgb(42, 42, 42);
            Calculator.BorderStyle = FormBorderStyle.None;
            Calculator.Controls.Add(txtLeftNumber);
            Calculator.Controls.Add(lblOperator);
            Calculator.Controls.Add(txtResult);
            Calculator.Controls.Add(lblMemoryView);
            Calculator.Controls.Add(lblMemoryStore);
            Calculator.Controls.Add(lblMemorySubtract);
            Calculator.Controls.Add(lblMemoryAdd);
            Calculator.Controls.Add(lblMemoryRecall);
            Calculator.Controls.Add(lblMemoryClear);
            Calculator.Controls.Add(btnEqual);
            Calculator.Controls.Add(btnComma);
            Calculator.Controls.Add(btnZero);
            Calculator.Controls.Add(btnPlusMinus);
            Calculator.Controls.Add(btnAddition);
            Calculator.Controls.Add(btnThree);
            Calculator.Controls.Add(btnTwo);
            Calculator.Controls.Add(btnOne);
            Calculator.Controls.Add(btnSubtraction);
            Calculator.Controls.Add(btnSix);
            Calculator.Controls.Add(btnFive);
            Calculator.Controls.Add(btnFour);
            Calculator.Controls.Add(btnMultiplication);
            Calculator.Controls.Add(btnNine);
            Calculator.Controls.Add(btnEight);
            Calculator.Controls.Add(btnSeven);
            Calculator.Controls.Add(btnDivision);
            Calculator.Controls.Add(btnSquareRoot);
            Calculator.Controls.Add(btnSquare);
            Calculator.Controls.Add(btnReciprocal);
            Calculator.Controls.Add(btnBackSpace);
            Calculator.Controls.Add(btnClear);
            Calculator.Controls.Add(btnClearEntry);
            Calculator.Controls.Add(BtnPercent);
            Calculator.Controls.Add(btnClose);
            Calculator.Customization = "Kioq/yAgIP8qKir/Kioq/xwcHP/+/v7/Kysr/xkZGf8=";
            Calculator.Dock = DockStyle.Fill;
            Calculator.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Calculator.Image = null;
            Calculator.Location = new Point(0, 0);
            Calculator.MinimumSize = new Size(200, 25);
            Calculator.Movable = false;
            Calculator.Name = "Calculator";
            Calculator.NoRounding = false;
            Calculator.Padding = new Padding(5, 25, 5, 5);
            Calculator.Sizable = false;
            Calculator.Size = new Size(326, 533);
            Calculator.SmartBounds = true;
            Calculator.StartPosition = FormStartPosition.CenterScreen;
            Calculator.TabIndex = 0;
            Calculator.Text = "Calculator";
            Calculator.TransparencyKey = Color.Purple;
            Calculator.Transparent = false;
            // 
            // txtLeftNumber
            // 
            txtLeftNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLeftNumber.BackColor = Color.FromArgb(42, 42, 42);
            txtLeftNumber.BorderStyle = BorderStyle.None;
            txtLeftNumber.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLeftNumber.ForeColor = Color.Gray;
            txtLeftNumber.Location = new Point(10, 98);
            txtLeftNumber.Margin = new Padding(0);
            txtLeftNumber.MaxLength = 15;
            txtLeftNumber.Name = "txtLeftNumber";
            txtLeftNumber.RightToLeft = RightToLeft.No;
            txtLeftNumber.ScrollBars = ScrollBars.Horizontal;
            txtLeftNumber.Size = new Size(290, 32);
            txtLeftNumber.TabIndex = 31;
            txtLeftNumber.TabStop = false;
            txtLeftNumber.TextAlign = HorizontalAlignment.Right;
            txtLeftNumber.WordWrap = false;
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOperator.ForeColor = Color.Gray;
            lblOperator.Location = new Point(295, 94);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(0, 37);
            lblOperator.TabIndex = 0;
            // 
            // txtResult
            // 
            txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtResult.BackColor = Color.FromArgb(42, 42, 42);
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.ForeColor = Color.Gray;
            txtResult.Location = new Point(1, 30);
            txtResult.Margin = new Padding(0);
            txtResult.MaxLength = 15;
            txtResult.Name = "txtResult";
            txtResult.RightToLeft = RightToLeft.No;
            txtResult.ScrollBars = ScrollBars.Horizontal;
            txtResult.Size = new Size(323, 64);
            txtResult.TabIndex = 0;
            txtResult.TabStop = false;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            txtResult.WordWrap = false;
            // 
            // lblMemoryView
            // 
            lblMemoryView.AutoSize = true;
            lblMemoryView.BackColor = Color.Transparent;
            lblMemoryView.Cursor = Cursors.Hand;
            lblMemoryView.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMemoryView.ForeColor = Color.FromArgb(76, 76, 77);
            lblMemoryView.Location = new Point(285, 138);
            lblMemoryView.Name = "lblMemoryView";
            lblMemoryView.Size = new Size(31, 20);
            lblMemoryView.TabIndex = 30;
            lblMemoryView.Text = "Mv";
            // 
            // lblMemoryStore
            // 
            lblMemoryStore.AutoSize = true;
            lblMemoryStore.BackColor = Color.Transparent;
            lblMemoryStore.Cursor = Cursors.Hand;
            lblMemoryStore.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMemoryStore.ForeColor = Color.FromArgb(76, 76, 77);
            lblMemoryStore.Location = new Point(230, 138);
            lblMemoryStore.Name = "lblMemoryStore";
            lblMemoryStore.Size = new Size(31, 20);
            lblMemoryStore.TabIndex = 29;
            lblMemoryStore.Text = "MS";
            // 
            // lblMemorySubtract
            // 
            lblMemorySubtract.AutoSize = true;
            lblMemorySubtract.BackColor = Color.Transparent;
            lblMemorySubtract.Cursor = Cursors.Hand;
            lblMemorySubtract.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMemorySubtract.ForeColor = Color.FromArgb(76, 76, 77);
            lblMemorySubtract.Location = new Point(175, 138);
            lblMemorySubtract.Name = "lblMemorySubtract";
            lblMemorySubtract.Size = new Size(29, 20);
            lblMemorySubtract.TabIndex = 28;
            lblMemorySubtract.Text = "M-";
            // 
            // lblMemoryAdd
            // 
            lblMemoryAdd.AutoSize = true;
            lblMemoryAdd.BackColor = Color.Transparent;
            lblMemoryAdd.Cursor = Cursors.Hand;
            lblMemoryAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMemoryAdd.ForeColor = Color.FromArgb(76, 76, 77);
            lblMemoryAdd.Location = new Point(120, 138);
            lblMemoryAdd.Name = "lblMemoryAdd";
            lblMemoryAdd.Size = new Size(34, 20);
            lblMemoryAdd.TabIndex = 27;
            lblMemoryAdd.Text = "M+";
            // 
            // lblMemoryRecall
            // 
            lblMemoryRecall.AutoSize = true;
            lblMemoryRecall.BackColor = Color.Transparent;
            lblMemoryRecall.Cursor = Cursors.Hand;
            lblMemoryRecall.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMemoryRecall.ForeColor = Color.FromArgb(76, 76, 77);
            lblMemoryRecall.Location = new Point(65, 138);
            lblMemoryRecall.Name = "lblMemoryRecall";
            lblMemoryRecall.Size = new Size(33, 20);
            lblMemoryRecall.TabIndex = 26;
            lblMemoryRecall.Text = "MR";
            // 
            // lblMemoryClear
            // 
            lblMemoryClear.AutoSize = true;
            lblMemoryClear.BackColor = Color.Transparent;
            lblMemoryClear.Cursor = Cursors.Hand;
            lblMemoryClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMemoryClear.ForeColor = Color.FromArgb(76, 76, 77);
            lblMemoryClear.Location = new Point(10, 138);
            lblMemoryClear.Name = "lblMemoryClear";
            lblMemoryClear.Size = new Size(32, 20);
            lblMemoryClear.TabIndex = 25;
            lblMemoryClear.Text = "MC";
            // 
            // btnEqual
            // 
            btnEqual.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnEqual.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEqual.Image = null;
            btnEqual.Location = new Point(242, 465);
            btnEqual.Name = "btnEqual";
            btnEqual.NoRounding = false;
            btnEqual.Size = new Size(80, 60);
            btnEqual.TabIndex = 24;
            btnEqual.Text = "=";
            btnEqual.TextAlignment = HorizontalAlignment.Center;
            btnEqual.Transparent = false;
            // 
            // btnComma
            // 
            btnComma.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnComma.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnComma.Image = null;
            btnComma.Location = new Point(163, 465);
            btnComma.Name = "btnComma";
            btnComma.NoRounding = false;
            btnComma.Size = new Size(80, 60);
            btnComma.TabIndex = 23;
            btnComma.Text = ",";
            btnComma.TextAlignment = HorizontalAlignment.Center;
            btnComma.Transparent = false;
            // 
            // btnZero
            // 
            btnZero.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnZero.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnZero.Image = null;
            btnZero.Location = new Point(83, 465);
            btnZero.Name = "btnZero";
            btnZero.NoRounding = false;
            btnZero.Size = new Size(80, 60);
            btnZero.TabIndex = 22;
            btnZero.Text = "0";
            btnZero.TextAlignment = HorizontalAlignment.Center;
            btnZero.Transparent = false;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnPlusMinus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPlusMinus.Image = null;
            btnPlusMinus.Location = new Point(3, 465);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.NoRounding = false;
            btnPlusMinus.Size = new Size(80, 60);
            btnPlusMinus.TabIndex = 21;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.TextAlignment = HorizontalAlignment.Center;
            btnPlusMinus.Transparent = false;
            // 
            // btnAddition
            // 
            btnAddition.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnAddition.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAddition.Image = null;
            btnAddition.Location = new Point(242, 405);
            btnAddition.Name = "btnAddition";
            btnAddition.NoRounding = false;
            btnAddition.Size = new Size(80, 60);
            btnAddition.TabIndex = 20;
            btnAddition.Text = "+";
            btnAddition.TextAlignment = HorizontalAlignment.Center;
            btnAddition.Transparent = false;
            // 
            // btnThree
            // 
            btnThree.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnThree.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnThree.Image = null;
            btnThree.Location = new Point(163, 405);
            btnThree.Name = "btnThree";
            btnThree.NoRounding = false;
            btnThree.Size = new Size(80, 60);
            btnThree.TabIndex = 19;
            btnThree.Text = "3";
            btnThree.TextAlignment = HorizontalAlignment.Center;
            btnThree.Transparent = false;
            // 
            // btnTwo
            // 
            btnTwo.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnTwo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTwo.Image = null;
            btnTwo.Location = new Point(83, 405);
            btnTwo.Name = "btnTwo";
            btnTwo.NoRounding = false;
            btnTwo.Size = new Size(80, 60);
            btnTwo.TabIndex = 18;
            btnTwo.Text = "2";
            btnTwo.TextAlignment = HorizontalAlignment.Center;
            btnTwo.Transparent = false;
            // 
            // btnOne
            // 
            btnOne.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnOne.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnOne.Image = null;
            btnOne.Location = new Point(3, 405);
            btnOne.Name = "btnOne";
            btnOne.NoRounding = false;
            btnOne.Size = new Size(80, 60);
            btnOne.TabIndex = 17;
            btnOne.Text = "1";
            btnOne.TextAlignment = HorizontalAlignment.Center;
            btnOne.Transparent = false;
            // 
            // btnSubtraction
            // 
            btnSubtraction.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSubtraction.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSubtraction.Image = null;
            btnSubtraction.Location = new Point(242, 344);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.NoRounding = false;
            btnSubtraction.Size = new Size(80, 60);
            btnSubtraction.TabIndex = 16;
            btnSubtraction.Text = "-";
            btnSubtraction.TextAlignment = HorizontalAlignment.Center;
            btnSubtraction.Transparent = false;
            // 
            // btnSix
            // 
            btnSix.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSix.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSix.Image = null;
            btnSix.Location = new Point(163, 344);
            btnSix.Name = "btnSix";
            btnSix.NoRounding = false;
            btnSix.Size = new Size(80, 60);
            btnSix.TabIndex = 15;
            btnSix.Text = "6";
            btnSix.TextAlignment = HorizontalAlignment.Center;
            btnSix.Transparent = false;
            // 
            // btnFive
            // 
            btnFive.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnFive.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnFive.Image = null;
            btnFive.Location = new Point(83, 344);
            btnFive.Name = "btnFive";
            btnFive.NoRounding = false;
            btnFive.Size = new Size(80, 60);
            btnFive.TabIndex = 14;
            btnFive.Text = "5";
            btnFive.TextAlignment = HorizontalAlignment.Center;
            btnFive.Transparent = false;
            // 
            // btnFour
            // 
            btnFour.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnFour.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnFour.Image = null;
            btnFour.Location = new Point(3, 344);
            btnFour.Name = "btnFour";
            btnFour.NoRounding = false;
            btnFour.Size = new Size(80, 60);
            btnFour.TabIndex = 13;
            btnFour.Text = "4";
            btnFour.TextAlignment = HorizontalAlignment.Center;
            btnFour.Transparent = false;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnMultiplication.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnMultiplication.Image = null;
            btnMultiplication.Location = new Point(242, 283);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.NoRounding = false;
            btnMultiplication.Size = new Size(80, 60);
            btnMultiplication.TabIndex = 12;
            btnMultiplication.Text = "X";
            btnMultiplication.TextAlignment = HorizontalAlignment.Center;
            btnMultiplication.Transparent = false;
            // 
            // btnNine
            // 
            btnNine.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnNine.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNine.Image = null;
            btnNine.Location = new Point(163, 283);
            btnNine.Name = "btnNine";
            btnNine.NoRounding = false;
            btnNine.Size = new Size(80, 60);
            btnNine.TabIndex = 11;
            btnNine.Text = "9";
            btnNine.TextAlignment = HorizontalAlignment.Center;
            btnNine.Transparent = false;
            // 
            // btnEight
            // 
            btnEight.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnEight.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEight.Image = null;
            btnEight.Location = new Point(83, 283);
            btnEight.Name = "btnEight";
            btnEight.NoRounding = false;
            btnEight.Size = new Size(80, 60);
            btnEight.TabIndex = 10;
            btnEight.Text = "8";
            btnEight.TextAlignment = HorizontalAlignment.Center;
            btnEight.Transparent = false;
            // 
            // btnSeven
            // 
            btnSeven.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSeven.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSeven.Image = null;
            btnSeven.Location = new Point(3, 283);
            btnSeven.Name = "btnSeven";
            btnSeven.NoRounding = false;
            btnSeven.Size = new Size(80, 60);
            btnSeven.TabIndex = 9;
            btnSeven.Text = "7";
            btnSeven.TextAlignment = HorizontalAlignment.Center;
            btnSeven.Transparent = false;
            // 
            // btnDivision
            // 
            btnDivision.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnDivision.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDivision.Image = null;
            btnDivision.Location = new Point(242, 222);
            btnDivision.Name = "btnDivision";
            btnDivision.NoRounding = false;
            btnDivision.Size = new Size(80, 60);
            btnDivision.TabIndex = 8;
            btnDivision.Text = "÷";
            btnDivision.TextAlignment = HorizontalAlignment.Center;
            btnDivision.Transparent = false;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSquareRoot.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSquareRoot.Image = null;
            btnSquareRoot.Location = new Point(163, 222);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.NoRounding = false;
            btnSquareRoot.Size = new Size(80, 60);
            btnSquareRoot.TabIndex = 7;
            btnSquareRoot.Text = "²√x";
            btnSquareRoot.TextAlignment = HorizontalAlignment.Center;
            btnSquareRoot.Transparent = false;
            // 
            // btnSquare
            // 
            btnSquare.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSquare.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSquare.Image = null;
            btnSquare.Location = new Point(83, 222);
            btnSquare.Name = "btnSquare";
            btnSquare.NoRounding = false;
            btnSquare.Size = new Size(80, 60);
            btnSquare.TabIndex = 6;
            btnSquare.Text = "x²";
            btnSquare.TextAlignment = HorizontalAlignment.Center;
            btnSquare.Transparent = false;
            // 
            // btnReciprocal
            // 
            btnReciprocal.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnReciprocal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnReciprocal.Image = null;
            btnReciprocal.Location = new Point(3, 222);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.NoRounding = false;
            btnReciprocal.Size = new Size(80, 60);
            btnReciprocal.TabIndex = 5;
            btnReciprocal.Text = "1/x";
            btnReciprocal.TextAlignment = HorizontalAlignment.Center;
            btnReciprocal.Transparent = false;
            // 
            // btnBackSpace
            // 
            btnBackSpace.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnBackSpace.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBackSpace.Image = null;
            btnBackSpace.Location = new Point(242, 161);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.NoRounding = false;
            btnBackSpace.Size = new Size(80, 60);
            btnBackSpace.TabIndex = 4;
            btnBackSpace.Text = "<=";
            btnBackSpace.TextAlignment = HorizontalAlignment.Center;
            btnBackSpace.Transparent = false;
            // 
            // btnClear
            // 
            btnClear.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnClear.Image = null;
            btnClear.Location = new Point(163, 161);
            btnClear.Name = "btnClear";
            btnClear.NoRounding = false;
            btnClear.Size = new Size(80, 60);
            btnClear.TabIndex = 3;
            btnClear.Text = "C";
            btnClear.TextAlignment = HorizontalAlignment.Center;
            btnClear.Transparent = false;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnClearEntry.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnClearEntry.Image = null;
            btnClearEntry.Location = new Point(83, 161);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.NoRounding = false;
            btnClearEntry.Size = new Size(80, 60);
            btnClearEntry.TabIndex = 2;
            btnClearEntry.Text = "CE";
            btnClearEntry.TextAlignment = HorizontalAlignment.Center;
            btnClearEntry.Transparent = false;
            // 
            // BtnPercent
            // 
            BtnPercent.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            BtnPercent.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BtnPercent.Image = null;
            BtnPercent.Location = new Point(3, 161);
            BtnPercent.Name = "BtnPercent";
            BtnPercent.NoRounding = false;
            BtnPercent.Size = new Size(80, 60);
            BtnPercent.TabIndex = 1;
            BtnPercent.Text = "%";
            BtnPercent.TextAlignment = HorizontalAlignment.Center;
            BtnPercent.Transparent = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Customization = "DQ/S/xhh8/8yMjL/Kioq/x5/9/8ND9L//v7+/yMjI/8qKir/";
            btnClose.DefaultAnchor = true;
            btnClose.DefaultLocation = true;
            btnClose.Font = new Font("Verdana", 8F);
            btnClose.Image = null;
            btnClose.Location = new Point(300, 3);
            btnClose.Name = "btnClose";
            btnClose.NoRounding = false;
            btnClose.Size = new Size(23, 21);
            btnClose.TabIndex = 0;
            btnClose.Text = "x";
            btnClose.Transparent = false;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(326, 533);
            Controls.Add(Calculator);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1366, 720);
            MinimumSize = new Size(126, 50);
            Name = "CalculatorForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formTheme1";
            TransparencyKey = Color.Purple;
            Calculator.ResumeLayout(false);
            Calculator.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.SpaceForm Calculator;
        private ReaLTaiizor.Controls.SpaceButton BtnPercent;
        private ReaLTaiizor.Controls.SpaceClose btnClose;
        private ReaLTaiizor.Controls.SpaceButton btnOne;
        private ReaLTaiizor.Controls.SpaceButton btnFour;
        private ReaLTaiizor.Controls.SpaceButton btnSeven;
        private ReaLTaiizor.Controls.SpaceButton btnReciprocal;
        private ReaLTaiizor.Controls.SpaceButton btnEqual;
        private ReaLTaiizor.Controls.SpaceButton btnComma;
        private ReaLTaiizor.Controls.SpaceButton btnZero;
        private ReaLTaiizor.Controls.SpaceButton btnPlusMinus;
        private ReaLTaiizor.Controls.SpaceButton btnAddition;
        private ReaLTaiizor.Controls.SpaceButton btnThree;
        private ReaLTaiizor.Controls.SpaceButton btnTwo;
        private ReaLTaiizor.Controls.SpaceButton btnSubtraction;
        private ReaLTaiizor.Controls.SpaceButton btnSix;
        private ReaLTaiizor.Controls.SpaceButton btnFive;
        private ReaLTaiizor.Controls.SpaceButton btnMultiplication;
        private ReaLTaiizor.Controls.SpaceButton btnNine;
        private ReaLTaiizor.Controls.SpaceButton btnEight;
        private ReaLTaiizor.Controls.SpaceButton btnDivision;
        private ReaLTaiizor.Controls.SpaceButton btnSquareRoot;
        private ReaLTaiizor.Controls.SpaceButton btnSquare;
        private ReaLTaiizor.Controls.SpaceButton btnBackSpace;
        private ReaLTaiizor.Controls.SpaceButton btnClear;
        private ReaLTaiizor.Controls.SpaceButton btnClearEntry;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblMemoryStore;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblMemorySubtract;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblMemoryAdd;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblMemoryRecall;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblMemoryClear;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblMemoryView;
        private ReaLTaiizor.Controls.CrownTextBox txtResult;
        private Label lblOperator;
        private ReaLTaiizor.Controls.CrownTextBox txtLeftNumber;
    }
}
