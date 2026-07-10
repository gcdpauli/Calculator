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
            txtResult = new ReaLTaiizor.Controls.CrownTextBox();
            dungeonHeaderLabel6 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel5 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel4 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel3 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
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
            Calculator.Controls.Add(txtResult);
            Calculator.Controls.Add(dungeonHeaderLabel6);
            Calculator.Controls.Add(dungeonHeaderLabel5);
            Calculator.Controls.Add(dungeonHeaderLabel4);
            Calculator.Controls.Add(dungeonHeaderLabel3);
            Calculator.Controls.Add(dungeonHeaderLabel2);
            Calculator.Controls.Add(dungeonHeaderLabel1);
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
            // txtResult
            // 
            txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResult.BackColor = Color.FromArgb(42, 42, 42);
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.ForeColor = Color.Gray;
            txtResult.Location = new Point(1, 30);
            txtResult.Margin = new Padding(0);
            txtResult.MaxLength = 16;
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.RightToLeft = RightToLeft.Yes;
            txtResult.Size = new Size(323, 76);
            txtResult.TabIndex = 0;
            txtResult.TabStop = false;
            txtResult.Text = "0";
            txtResult.WordWrap = false;
            // 
            // dungeonHeaderLabel6
            // 
            dungeonHeaderLabel6.AutoSize = true;
            dungeonHeaderLabel6.BackColor = Color.Transparent;
            dungeonHeaderLabel6.Cursor = Cursors.Hand;
            dungeonHeaderLabel6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel6.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel6.Location = new Point(285, 138);
            dungeonHeaderLabel6.Name = "dungeonHeaderLabel6";
            dungeonHeaderLabel6.Size = new Size(31, 20);
            dungeonHeaderLabel6.TabIndex = 30;
            dungeonHeaderLabel6.Text = "Mv";
            // 
            // dungeonHeaderLabel5
            // 
            dungeonHeaderLabel5.AutoSize = true;
            dungeonHeaderLabel5.BackColor = Color.Transparent;
            dungeonHeaderLabel5.Cursor = Cursors.Hand;
            dungeonHeaderLabel5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel5.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel5.Location = new Point(230, 138);
            dungeonHeaderLabel5.Name = "dungeonHeaderLabel5";
            dungeonHeaderLabel5.Size = new Size(31, 20);
            dungeonHeaderLabel5.TabIndex = 29;
            dungeonHeaderLabel5.Text = "MS";
            // 
            // dungeonHeaderLabel4
            // 
            dungeonHeaderLabel4.AutoSize = true;
            dungeonHeaderLabel4.BackColor = Color.Transparent;
            dungeonHeaderLabel4.Cursor = Cursors.Hand;
            dungeonHeaderLabel4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel4.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel4.Location = new Point(175, 138);
            dungeonHeaderLabel4.Name = "dungeonHeaderLabel4";
            dungeonHeaderLabel4.Size = new Size(29, 20);
            dungeonHeaderLabel4.TabIndex = 28;
            dungeonHeaderLabel4.Text = "M-";
            // 
            // dungeonHeaderLabel3
            // 
            dungeonHeaderLabel3.AutoSize = true;
            dungeonHeaderLabel3.BackColor = Color.Transparent;
            dungeonHeaderLabel3.Cursor = Cursors.Hand;
            dungeonHeaderLabel3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel3.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel3.Location = new Point(120, 138);
            dungeonHeaderLabel3.Name = "dungeonHeaderLabel3";
            dungeonHeaderLabel3.Size = new Size(34, 20);
            dungeonHeaderLabel3.TabIndex = 27;
            dungeonHeaderLabel3.Text = "M+";
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = Color.Transparent;
            dungeonHeaderLabel2.Cursor = Cursors.Hand;
            dungeonHeaderLabel2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel2.Location = new Point(65, 138);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new Size(33, 20);
            dungeonHeaderLabel2.TabIndex = 26;
            dungeonHeaderLabel2.Text = "MR";
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Cursor = Cursors.Hand;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(10, 138);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(32, 20);
            dungeonHeaderLabel1.TabIndex = 25;
            dungeonHeaderLabel1.Text = "MC";
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
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel5;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel4;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel3;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel6;
        private ReaLTaiizor.Controls.CrownTextBox txtResult;
    }
}
