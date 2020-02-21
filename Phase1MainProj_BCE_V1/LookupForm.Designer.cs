namespace Phase1MainProj_BCE_V1
{
    partial class LookupForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEnterId = new System.Windows.Forms.Label();
            this.txtEnterID = new System.Windows.Forms.TextBox();
            this.btnCancelLookup = new System.Windows.Forms.Button();
            this.txtDisplayEmpInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(34, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 40);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblEnterId
            // 
            this.lblEnterId.AutoSize = true;
            this.lblEnterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterId.Location = new System.Drawing.Point(12, 9);
            this.lblEnterId.Name = "lblEnterId";
            this.lblEnterId.Size = new System.Drawing.Size(174, 25);
            this.lblEnterId.TabIndex = 1;
            this.lblEnterId.Text = "Enter Employee ID";
            // 
            // txtEnterID
            // 
            this.txtEnterID.Location = new System.Drawing.Point(34, 37);
            this.txtEnterID.Name = "txtEnterID";
            this.txtEnterID.Size = new System.Drawing.Size(169, 22);
            this.txtEnterID.TabIndex = 2;
            // 
            // btnCancelLookup
            // 
            this.btnCancelLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLookup.Location = new System.Drawing.Point(196, 87);
            this.btnCancelLookup.Name = "btnCancelLookup";
            this.btnCancelLookup.Size = new System.Drawing.Size(145, 40);
            this.btnCancelLookup.TabIndex = 4;
            this.btnCancelLookup.Text = "Cancel";
            this.btnCancelLookup.UseVisualStyleBackColor = true;
            this.btnCancelLookup.Click += new System.EventHandler(this.btnCancelLookup_Click);
            // 
            // txtDisplayEmpInfo
            // 
            this.txtDisplayEmpInfo.Location = new System.Drawing.Point(12, 133);
            this.txtDisplayEmpInfo.Name = "txtDisplayEmpInfo";
            this.txtDisplayEmpInfo.Size = new System.Drawing.Size(356, 330);
            this.txtDisplayEmpInfo.TabIndex = 5;
            this.txtDisplayEmpInfo.Text = "";
            // 
            // LookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 475);
            this.Controls.Add(this.txtDisplayEmpInfo);
            this.Controls.Add(this.btnCancelLookup);
            this.Controls.Add(this.txtEnterID);
            this.Controls.Add(this.lblEnterId);
            this.Controls.Add(this.btnSearch);
            this.Name = "LookupForm";
            this.Text = "LookupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblEnterId;
        private System.Windows.Forms.TextBox txtEnterID;
        private System.Windows.Forms.Button btnCancelLookup;
        private System.Windows.Forms.RichTextBox txtDisplayEmpInfo;
    }
}