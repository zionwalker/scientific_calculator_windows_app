namespace Scient_Calculator
{
    partial class Calculator
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
            txtResult = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            standardToolStripMenuItem = new ToolStripMenuItem();
            scientficToolStripMenuItem = new ToolStripMenuItem();
            tempratureToolStripMenuItem = new ToolStripMenuItem();
            unitConversionToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            btnBS = new Button();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnPM = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSub = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMult = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEquals = new Button();
            btnDiv = new Button();
            eToolStripMenuItem = new ToolStripMenuItem();
            btnPi = new Button();
            btnLog = new Button();
            btnSqrt = new Button();
            btnx2 = new Button();
            btnSinh = new Button();
            btnSin = new Button();
            btnDec = new Button();
            btnx3 = new Button();
            btnCosh = new Button();
            btnCos = new Button();
            btnTanh = new Button();
            btnBin = new Button();
            btnTan = new Button();
            btnHex = new Button();
            btn1x = new Button();
            btnlnx = new Button();
            btnExp = new Button();
            btnMod = new Button();
            btnOct = new Button();
            btnPer = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Location = new Point(12, 49);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(664, 41);
            txtResult.TabIndex = 1;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            txtResult.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(689, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standardToolStripMenuItem, scientficToolStripMenuItem, tempratureToolStripMenuItem, unitConversionToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            standardToolStripMenuItem.Size = new Size(159, 22);
            standardToolStripMenuItem.Text = "Standard";
            standardToolStripMenuItem.Click += standardToolStripMenuItem_Click;
            // 
            // scientficToolStripMenuItem
            // 
            scientficToolStripMenuItem.Name = "scientficToolStripMenuItem";
            scientficToolStripMenuItem.Size = new Size(159, 22);
            scientficToolStripMenuItem.Text = "Scientfic";
            scientficToolStripMenuItem.Click += scientficToolStripMenuItem_Click;
            // 
            // tempratureToolStripMenuItem
            // 
            tempratureToolStripMenuItem.Name = "tempratureToolStripMenuItem";
            tempratureToolStripMenuItem.Size = new Size(159, 22);
            tempratureToolStripMenuItem.Text = "Temprature";
            // 
            // unitConversionToolStripMenuItem
            // 
            unitConversionToolStripMenuItem.Name = "unitConversionToolStripMenuItem";
            unitConversionToolStripMenuItem.Size = new Size(159, 22);
            unitConversionToolStripMenuItem.Text = "Unit Conversion";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(159, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // btnBS
            // 
            btnBS.Font = new Font("Wingdings", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBS.Location = new Point(12, 105);
            btnBS.Name = "btnBS";
            btnBS.Size = new Size(75, 72);
            btnBS.TabIndex = 6;
            btnBS.Text = "x";
            btnBS.UseVisualStyleBackColor = true;
            btnBS.Click += btnBS_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearEntry.Location = new Point(93, 105);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(75, 72);
            btnClearEntry.TabIndex = 6;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(173, 105);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 72);
            btnClear.TabIndex = 6;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPM
            // 
            btnPM.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPM.Location = new Point(254, 105);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(75, 72);
            btnPM.TabIndex = 6;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += btnPM_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 183);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 72);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += EnterNumbers;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(93, 183);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 72);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += EnterNumbers;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(173, 183);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 72);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += EnterNumbers;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(254, 183);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 72);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += numberOper;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 261);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 72);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += EnterNumbers;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(93, 261);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 72);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += EnterNumbers;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(173, 261);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 72);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += EnterNumbers;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSub.Location = new Point(254, 261);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 72);
            btnSub.TabIndex = 6;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += numberOper;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 339);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 72);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += EnterNumbers;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(92, 339);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 72);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += EnterNumbers;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(174, 339);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 72);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += EnterNumbers;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMult.Location = new Point(255, 339);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(75, 72);
            btnMult.TabIndex = 6;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += numberOper;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(12, 417);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 72);
            btn0.TabIndex = 6;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += EnterNumbers;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(93, 417);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(75, 72);
            btnDot.TabIndex = 6;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += EnterNumbers;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.Location = new Point(173, 417);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(75, 72);
            btnEquals.TabIndex = 6;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiv.Location = new Point(255, 417);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 72);
            btnDiv.TabIndex = 6;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += numberOper;
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(32, 19);
            // 
            // btnPi
            // 
            btnPi.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPi.Location = new Point(358, 105);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(75, 72);
            btnPi.TabIndex = 6;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = true;
            btnPi.Click += btnPi_Click;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLog.Location = new Point(439, 105);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(75, 72);
            btnLog.TabIndex = 6;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSqrt.Location = new Point(520, 105);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(75, 72);
            btnSqrt.TabIndex = 6;
            btnSqrt.Text = "Sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnx2
            // 
            btnx2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnx2.Location = new Point(601, 105);
            btnx2.Name = "btnx2";
            btnx2.Size = new Size(75, 72);
            btnx2.TabIndex = 6;
            btnx2.Text = "x²";
            btnx2.UseVisualStyleBackColor = true;
            btnx2.Click += btnSin_Click;
            // 
            // btnSinh
            // 
            btnSinh.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSinh.Location = new Point(358, 183);
            btnSinh.Name = "btnSinh";
            btnSinh.Size = new Size(75, 72);
            btnSinh.TabIndex = 6;
            btnSinh.Text = "Sinh";
            btnSinh.UseVisualStyleBackColor = true;
            btnSinh.Click += btnSinh_Click;
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSin.Location = new Point(439, 183);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(75, 72);
            btnSin.TabIndex = 6;
            btnSin.Text = "Sin";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += btnSin_Click_1;
            // 
            // btnDec
            // 
            btnDec.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDec.Location = new Point(520, 183);
            btnDec.Name = "btnDec";
            btnDec.Size = new Size(75, 72);
            btnDec.TabIndex = 6;
            btnDec.Text = "Dec";
            btnDec.UseVisualStyleBackColor = true;
            // 
            // btnx3
            // 
            btnx3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnx3.Location = new Point(601, 183);
            btnx3.Name = "btnx3";
            btnx3.Size = new Size(75, 72);
            btnx3.TabIndex = 6;
            btnx3.Text = "x³";
            btnx3.UseVisualStyleBackColor = true;
            btnx3.Click += btnx3_Click;
            // 
            // btnCosh
            // 
            btnCosh.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCosh.Location = new Point(358, 261);
            btnCosh.Name = "btnCosh";
            btnCosh.Size = new Size(75, 72);
            btnCosh.TabIndex = 6;
            btnCosh.Text = "Cosh";
            btnCosh.UseVisualStyleBackColor = true;
            btnCosh.Click += btnCosh_Click;
            // 
            // btnCos
            // 
            btnCos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCos.Location = new Point(439, 261);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(75, 72);
            btnCos.TabIndex = 6;
            btnCos.Text = "Cos";
            btnCos.UseVisualStyleBackColor = true;
            btnCos.Click += btnCos_Click;
            // 
            // btnTanh
            // 
            btnTanh.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTanh.Location = new Point(358, 339);
            btnTanh.Name = "btnTanh";
            btnTanh.Size = new Size(75, 72);
            btnTanh.TabIndex = 6;
            btnTanh.Text = "Tanh";
            btnTanh.UseVisualStyleBackColor = true;
            btnTanh.Click += btnTanh_Click;
            // 
            // btnBin
            // 
            btnBin.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBin.Location = new Point(520, 261);
            btnBin.Name = "btnBin";
            btnBin.Size = new Size(75, 72);
            btnBin.TabIndex = 6;
            btnBin.Text = "Bin";
            btnBin.UseVisualStyleBackColor = true;
            // 
            // btnTan
            // 
            btnTan.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTan.Location = new Point(439, 339);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(75, 72);
            btnTan.TabIndex = 6;
            btnTan.Text = "Tan";
            btnTan.UseVisualStyleBackColor = true;
            btnTan.Click += btnTan_Click;
            // 
            // btnHex
            // 
            btnHex.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnHex.Location = new Point(520, 339);
            btnHex.Name = "btnHex";
            btnHex.Size = new Size(75, 72);
            btnHex.TabIndex = 6;
            btnHex.Text = "Hex";
            btnHex.UseVisualStyleBackColor = true;
            // 
            // btn1x
            // 
            btn1x.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1x.Location = new Point(601, 261);
            btn1x.Name = "btn1x";
            btn1x.Size = new Size(75, 72);
            btn1x.TabIndex = 6;
            btn1x.Text = "1/x";
            btn1x.UseVisualStyleBackColor = true;
            // 
            // btnlnx
            // 
            btnlnx.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnlnx.Location = new Point(601, 339);
            btnlnx.Name = "btnlnx";
            btnlnx.Size = new Size(75, 72);
            btnlnx.TabIndex = 6;
            btnlnx.Text = "ln x";
            btnlnx.UseVisualStyleBackColor = true;
            // 
            // btnExp
            // 
            btnExp.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExp.Location = new Point(358, 417);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(75, 72);
            btnExp.TabIndex = 6;
            btnExp.Text = "Exp";
            btnExp.UseVisualStyleBackColor = true;
            btnExp.Click += numberOper;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMod.Location = new Point(439, 417);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 72);
            btnMod.TabIndex = 6;
            btnMod.Text = "Mod";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += numberOper;
            // 
            // btnOct
            // 
            btnOct.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOct.Location = new Point(520, 417);
            btnOct.Name = "btnOct";
            btnOct.Size = new Size(75, 72);
            btnOct.TabIndex = 6;
            btnOct.Text = "Oct";
            btnOct.UseVisualStyleBackColor = true;
            // 
            // btnPer
            // 
            btnPer.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPer.Location = new Point(601, 417);
            btnPer.Name = "btnPer";
            btnPer.Size = new Size(75, 72);
            btnPer.TabIndex = 6;
            btnPer.Text = "%";
            btnPer.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 496);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(btnPer);
            Controls.Add(btnlnx);
            Controls.Add(btnx3);
            Controls.Add(btn1x);
            Controls.Add(btnx2);
            Controls.Add(btnOct);
            Controls.Add(btnHex);
            Controls.Add(btnDec);
            Controls.Add(btnMod);
            Controls.Add(btnTan);
            Controls.Add(btnSin);
            Controls.Add(btnBin);
            Controls.Add(btnSqrt);
            Controls.Add(btnExp);
            Controls.Add(btnTanh);
            Controls.Add(btnCos);
            Controls.Add(btnSinh);
            Controls.Add(btnCosh);
            Controls.Add(btnLog);
            Controls.Add(btnPi);
            Controls.Add(btnPM);
            Controls.Add(btnEquals);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btnClear);
            Controls.Add(btnDot);
            Controls.Add(btn2);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnClearEntry);
            Controls.Add(btnBS);
            Controls.Add(txtResult);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Calculator";
            Text = "Calculator";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtResult;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private Button btnBS;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnPM;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSub;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMult;
        private Button btn0;
        private Button btnDot;
        private Button btnEquals;
        private Button btnDiv;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem scientficToolStripMenuItem;
        private ToolStripMenuItem tempratureToolStripMenuItem;
        private ToolStripMenuItem unitConversionToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnPi;
        private Button btnLog;
        private Button btnSqrt;
        private Button btnx2;
        private Button btnSinh;
        private Button btnSin;
        private Button btnDec;
        private Button btnx3;
        private Button btnCosh;
        private Button btnCos;
        private Button btnTanh;
        private Button btnBin;
        private Button btnTan;
        private Button btnHex;
        private Button btn1x;
        private Button btnlnx;
        private Button btnExp;
        private Button btnMod;
        private Button btnOct;
        private Button btnPer;
    }
}
