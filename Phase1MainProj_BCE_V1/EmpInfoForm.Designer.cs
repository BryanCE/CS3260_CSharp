namespace Phase1MainProj_BCE_V1
{
    partial class EmpInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpInfoForm));
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblPayType = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblEmpType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPayType = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCommision = new System.Windows.Forms.Label();
            this.txtCommision = new System.Windows.Forms.TextBox();
            this.lblDisplayEmpID = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(12, 9);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(114, 25);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name*";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(12, 61);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(114, 25);
            this.lblLName.TabIndex = 1;
            this.lblLName.Text = "Last Name*";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(276, 9);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(129, 25);
            this.lblEmpID.TabIndex = 2;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // lblPayType
            // 
            this.lblPayType.AutoSize = true;
            this.lblPayType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayType.Location = new System.Drawing.Point(276, 52);
            this.lblPayType.Name = "lblPayType";
            this.lblPayType.Size = new System.Drawing.Size(104, 25);
            this.lblPayType.TabIndex = 3;
            this.lblPayType.Text = "Pay Type*";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(276, 114);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(146, 25);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "Hours Worked*";
            // 
            // lblRequired
            // 
            this.lblRequired.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.Location = new System.Drawing.Point(450, 330);
            this.lblRequired.Margin = new System.Windows.Forms.Padding(3);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(169, 17);
            this.lblRequired.TabIndex = 5;
            this.lblRequired.Text = "* Indicates Required Field";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(17, 33);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(180, 22);
            this.txtFName.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(17, 89);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(180, 22);
            this.txtLName.TabIndex = 7;
            // 
            // lblEmpType
            // 
            this.lblEmpType.AutoSize = true;
            this.lblEmpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpType.Location = new System.Drawing.Point(12, 114);
            this.lblEmpType.Name = "lblEmpType";
            this.lblEmpType.Size = new System.Drawing.Size(157, 25);
            this.lblEmpType.TabIndex = 8;
            this.lblEmpType.Text = "Employee Type*";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hourly",
            "Salary",
            "Sales",
            "Contract"});
            this.comboBox1.Location = new System.Drawing.Point(17, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPayType
            // 
            this.txtPayType.Location = new System.Drawing.Point(281, 80);
            this.txtPayType.Name = "txtPayType";
            this.txtPayType.Size = new System.Drawing.Size(180, 22);
            this.txtPayType.TabIndex = 10;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(281, 142);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(180, 22);
            this.txtHoursWorked.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(128, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 34);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCommision
            // 
            this.lblCommision.AutoSize = true;
            this.lblCommision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommision.Location = new System.Drawing.Point(276, 167);
            this.lblCommision.Name = "lblCommision";
            this.lblCommision.Size = new System.Drawing.Size(118, 25);
            this.lblCommision.TabIndex = 14;
            this.lblCommision.Text = "Commision*";
            this.lblCommision.Visible = false;
            // 
            // txtCommision
            // 
            this.txtCommision.Location = new System.Drawing.Point(281, 195);
            this.txtCommision.Name = "txtCommision";
            this.txtCommision.Size = new System.Drawing.Size(180, 22);
            this.txtCommision.TabIndex = 15;
            this.txtCommision.Visible = false;
            // 
            // lblDisplayEmpID
            // 
            this.lblDisplayEmpID.AutoSize = true;
            this.lblDisplayEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayEmpID.Location = new System.Drawing.Point(411, 9);
            this.lblDisplayEmpID.Name = "lblDisplayEmpID";
            this.lblDisplayEmpID.Size = new System.Drawing.Size(32, 25);
            this.lblDisplayEmpID.TabIndex = 16;
            this.lblDisplayEmpID.Text = "    ";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(281, 239);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(28, 17);
            this.lblError.TabIndex = 17;
            this.lblError.Text = "     ";
            // 
            // EmpInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 351);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblDisplayEmpID);
            this.Controls.Add(this.txtCommision);
            this.Controls.Add(this.lblCommision);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtPayType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblEmpType);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblPayType);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmpInfoForm";
            this.Text = "Employee Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblPayType;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblEmpType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtPayType;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCommision;
        private System.Windows.Forms.TextBox txtCommision;
        private System.Windows.Forms.Label lblDisplayEmpID;
        private System.Windows.Forms.Label lblError;
    }
}