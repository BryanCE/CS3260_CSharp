namespace Lab06_BCE_V1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTest = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCharacter = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.RichTextBox();
            this.lblInteger = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.lblString = new System.Windows.Forms.Label();
            this.lblFuncCalled = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(113, 144);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(200, 50);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test Delegates";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(16, 32);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(132, 22);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(181, 32);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 22);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtCharacter
            // 
            this.txtCharacter.Location = new System.Drawing.Point(344, 32);
            this.txtCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.txtCharacter.Name = "txtCharacter";
            this.txtCharacter.Size = new System.Drawing.Size(132, 22);
            this.txtCharacter.TabIndex = 2;
            this.txtCharacter.TextChanged += new System.EventHandler(this.txtCharacter_TextChanged);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(506, 32);
            this.txtWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(132, 22);
            this.txtWord.TabIndex = 3;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(13, 62);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(625, 74);
            this.txtDisplay.TabIndex = 5;
            this.txtDisplay.Text = "";
            // 
            // lblInteger
            // 
            this.lblInteger.AutoSize = true;
            this.lblInteger.Location = new System.Drawing.Point(13, 9);
            this.lblInteger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInteger.Name = "lblInteger";
            this.lblInteger.Size = new System.Drawing.Size(52, 17);
            this.lblInteger.TabIndex = 6;
            this.lblInteger.Text = "Integer";
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(178, 9);
            this.lblDouble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(53, 17);
            this.lblDouble.TabIndex = 7;
            this.lblDouble.Text = "Double";
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Location = new System.Drawing.Point(341, 9);
            this.lblCharacter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(70, 17);
            this.lblCharacter.TabIndex = 8;
            this.lblCharacter.Text = "Character";
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(503, 9);
            this.lblString.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(45, 17);
            this.lblString.TabIndex = 9;
            this.lblString.Text = "String";
            // 
            // lblFuncCalled
            // 
            this.lblFuncCalled.AutoSize = true;
            this.lblFuncCalled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncCalled.Location = new System.Drawing.Point(8, 212);
            this.lblFuncCalled.Name = "lblFuncCalled";
            this.lblFuncCalled.Size = new System.Drawing.Size(138, 25);
            this.lblFuncCalled.TabIndex = 10;
            this.lblFuncCalled.Text = "Delegate used";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(344, 144);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 256);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblFuncCalled);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.lblCharacter);
            this.Controls.Add(this.lblDouble);
            this.Controls.Add(this.lblInteger);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.txtCharacter);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnTest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Delegates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCharacter;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.RichTextBox txtDisplay;
        private System.Windows.Forms.Label lblInteger;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblFuncCalled;
        private System.Windows.Forms.Button btnExit;
    }
}

