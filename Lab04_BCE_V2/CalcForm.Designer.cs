namespace Lab04_BCE_V2
{
    partial class CalcForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblOp1 = new System.Windows.Forms.Label();
            this.lblOp2 = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.pnlCalcBtns = new System.Windows.Forms.Panel();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlCalcBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(29, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(444, 75);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "1. Enter two complex numbers, in the form x.x+y.yi\r\n2. Select operation\r\n3. Calcu" +
    "late ";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOp1
            // 
            this.lblOp1.AutoSize = true;
            this.lblOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp1.Location = new System.Drawing.Point(11, 122);
            this.lblOp1.Name = "lblOp1";
            this.lblOp1.Size = new System.Drawing.Size(40, 20);
            this.lblOp1.TabIndex = 1;
            this.lblOp1.Text = "Op1";
            // 
            // lblOp2
            // 
            this.lblOp2.AutoSize = true;
            this.lblOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp2.Location = new System.Drawing.Point(253, 122);
            this.lblOp2.Name = "lblOp2";
            this.lblOp2.Size = new System.Drawing.Size(40, 20);
            this.lblOp2.TabIndex = 2;
            this.lblOp2.Text = "Op2";
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(57, 122);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(190, 22);
            this.txtOperand1.TabIndex = 3;
            this.txtOperand1.Text = "Enter Complex Number 1";
            this.txtOperand1.TextChanged += new System.EventHandler(this.txtOperand1_TextChanged);
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(299, 122);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(192, 22);
            this.txtOperand2.TabIndex = 4;
            this.txtOperand2.Text = "Enter Complex Number 2";
            this.txtOperand2.TextChanged += new System.EventHandler(this.txtOperand2_TextChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(15, 223);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(476, 66);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlCalcBtns
            // 
            this.pnlCalcBtns.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlCalcBtns.Controls.Add(this.btnAllClear);
            this.pnlCalcBtns.Controls.Add(this.btnClear);
            this.pnlCalcBtns.Controls.Add(this.btnDivide);
            this.pnlCalcBtns.Controls.Add(this.btnEquals);
            this.pnlCalcBtns.Controls.Add(this.btnMultiply);
            this.pnlCalcBtns.Controls.Add(this.btnSubtract);
            this.pnlCalcBtns.Controls.Add(this.btnAdd);
            this.pnlCalcBtns.Location = new System.Drawing.Point(12, 150);
            this.pnlCalcBtns.Name = "pnlCalcBtns";
            this.pnlCalcBtns.Size = new System.Drawing.Size(484, 67);
            this.pnlCalcBtns.TabIndex = 6;
            // 
            // btnAllClear
            // 
            this.btnAllClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllClear.Location = new System.Drawing.Point(399, 3);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(80, 60);
            this.btnAllClear.TabIndex = 13;
            this.btnAllClear.Text = "AC";
            this.btnAllClear.UseVisualStyleBackColor = true;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(333, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 60);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(3, 3);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 60);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(267, 3);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(60, 60);
            this.btnEquals.TabIndex = 11;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(69, 3);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 60);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "•";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(201, 3);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(60, 60);
            this.btnSubtract.TabIndex = 10;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(135, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 60);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 319);
            this.Controls.Add(this.pnlCalcBtns);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.lblOp2);
            this.Controls.Add(this.lblOp1);
            this.Controls.Add(this.lblInstructions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalcForm";
            this.Text = "Complex Number Calculator";
            this.pnlCalcBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblOp1;
        private System.Windows.Forms.Label lblOp2;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Panel pnlCalcBtns;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
    }
}

