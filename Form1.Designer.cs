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
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            button32 = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEquals = new Button();
            btnDiv = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Location = new Point(12, 49);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(317, 41);
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
            menuStrip1.Size = new Size(339, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standardToolStripMenuItem, scientficToolStripMenuItem, tempratureToolStripMenuItem, unitConversionToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            standardToolStripMenuItem.Size = new Size(159, 22);
            standardToolStripMenuItem.Text = "Standard";
            // 
            // scientficToolStripMenuItem
            // 
            scientficToolStripMenuItem.Name = "scientficToolStripMenuItem";
            scientficToolStripMenuItem.Size = new Size(159, 22);
            scientficToolStripMenuItem.Text = "Scientfic";
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
            // 
            // button17
            // 
            button17.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Location = new Point(347, 105);
            button17.Name = "button17";
            button17.Size = new Size(75, 72);
            button17.TabIndex = 6;
            button17.Text = "button1";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button18.Location = new Point(428, 105);
            button18.Name = "button18";
            button18.Size = new Size(75, 72);
            button18.TabIndex = 6;
            button18.Text = "button1";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(347, 183);
            button19.Name = "button19";
            button19.Size = new Size(75, 72);
            button19.TabIndex = 6;
            button19.Text = "button1";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button20.Location = new Point(428, 183);
            button20.Name = "button20";
            button20.Size = new Size(75, 72);
            button20.TabIndex = 6;
            button20.Text = "button1";
            button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button21.Location = new Point(347, 261);
            button21.Name = "button21";
            button21.Size = new Size(75, 72);
            button21.TabIndex = 6;
            button21.Text = "button1";
            button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button22.Location = new Point(428, 261);
            button22.Name = "button22";
            button22.Size = new Size(75, 72);
            button22.TabIndex = 6;
            button22.Text = "button1";
            button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            button23.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button23.Location = new Point(347, 348);
            button23.Name = "button23";
            button23.Size = new Size(75, 72);
            button23.TabIndex = 6;
            button23.Text = "button1";
            button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            button24.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button24.Location = new Point(428, 348);
            button24.Name = "button24";
            button24.Size = new Size(75, 72);
            button24.TabIndex = 6;
            button24.Text = "button1";
            button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            button25.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button25.Location = new Point(508, 105);
            button25.Name = "button25";
            button25.Size = new Size(75, 72);
            button25.TabIndex = 6;
            button25.Text = "button1";
            button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            button26.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button26.Location = new Point(508, 183);
            button26.Name = "button26";
            button26.Size = new Size(75, 72);
            button26.TabIndex = 6;
            button26.Text = "button1";
            button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            button27.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button27.Location = new Point(508, 261);
            button27.Name = "button27";
            button27.Size = new Size(75, 72);
            button27.TabIndex = 6;
            button27.Text = "button1";
            button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            button28.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button28.Location = new Point(508, 348);
            button28.Name = "button28";
            button28.Size = new Size(75, 72);
            button28.TabIndex = 6;
            button28.Text = "button1";
            button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            button29.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button29.Location = new Point(589, 105);
            button29.Name = "button29";
            button29.Size = new Size(75, 72);
            button29.TabIndex = 6;
            button29.Text = "button1";
            button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            button30.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button30.Location = new Point(589, 183);
            button30.Name = "button30";
            button30.Size = new Size(75, 72);
            button30.TabIndex = 6;
            button30.Text = "button1";
            button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            button31.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button31.Location = new Point(589, 261);
            button31.Name = "button31";
            button31.Size = new Size(75, 72);
            button31.TabIndex = 6;
            button31.Text = "button1";
            button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            button32.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button32.Location = new Point(589, 348);
            button32.Name = "button32";
            button32.Size = new Size(75, 72);
            button32.TabIndex = 6;
            button32.Text = "button1";
            button32.UseVisualStyleBackColor = true;
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
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 492);
            Controls.Add(button32);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(button31);
            Controls.Add(btnSub);
            Controls.Add(button30);
            Controls.Add(btnAdd);
            Controls.Add(button29);
            Controls.Add(btnPM);
            Controls.Add(button28);
            Controls.Add(btnEquals);
            Controls.Add(btn3);
            Controls.Add(button27);
            Controls.Add(btn6);
            Controls.Add(button26);
            Controls.Add(btn9);
            Controls.Add(button25);
            Controls.Add(btnClear);
            Controls.Add(btnDot);
            Controls.Add(button24);
            Controls.Add(btn2);
            Controls.Add(btn0);
            Controls.Add(button23);
            Controls.Add(btn1);
            Controls.Add(button22);
            Controls.Add(btn5);
            Controls.Add(button21);
            Controls.Add(btn4);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(btn8);
            Controls.Add(button18);
            Controls.Add(btn7);
            Controls.Add(button17);
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
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem scientficToolStripMenuItem;
        private ToolStripMenuItem tempratureToolStripMenuItem;
        private ToolStripMenuItem unitConversionToolStripMenuItem;
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
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private Button button31;
        private Button button32;
        private Button btn0;
        private Button btnDot;
        private Button btnEquals;
        private Button btnDiv;
    }
}
