namespace Phase2MainProj_BCE_V1
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
            this.txtEnterID = new System.Windows.Forms.TextBox();
            this.btnCancelLookup = new System.Windows.Forms.Button();
            this.txtDisplayEmpInfo = new System.Windows.Forms.RichTextBox();
            this.lblSearchInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(32, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEnterID
            // 
            this.txtEnterID.Location = new System.Drawing.Point(17, 44);
            this.txtEnterID.Name = "txtEnterID";
            this.txtEnterID.Size = new System.Drawing.Size(413, 22);
            this.txtEnterID.TabIndex = 0;
            // 
            // btnCancelLookup
            // 
            this.btnCancelLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLookup.Location = new System.Drawing.Point(285, 85);
            this.btnCancelLookup.Name = "btnCancelLookup";
            this.btnCancelLookup.Size = new System.Drawing.Size(145, 40);
            this.btnCancelLookup.TabIndex = 2;
            this.btnCancelLookup.Text = "Cancel";
            this.btnCancelLookup.UseVisualStyleBackColor = true;
            this.btnCancelLookup.Click += new System.EventHandler(this.btnCancelLookup_Click);
            // 
            // txtDisplayEmpInfo
            // 
            this.txtDisplayEmpInfo.Location = new System.Drawing.Point(12, 152);
            this.txtDisplayEmpInfo.Name = "txtDisplayEmpInfo";
            this.txtDisplayEmpInfo.Size = new System.Drawing.Size(418, 330);
            this.txtDisplayEmpInfo.TabIndex = 5;
            this.txtDisplayEmpInfo.Text = "";
            // 
            // lblSearchInstructions
            // 
            this.lblSearchInstructions.AutoSize = true;
            this.lblSearchInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblSearchInstructions.Name = "lblSearchInstructions";
            this.lblSearchInstructions.Size = new System.Drawing.Size(418, 25);
            this.lblSearchInstructions.TabIndex = 6;
            this.lblSearchInstructions.Text = "Search by: ID, F. Name, L. Name, or Full Name";
            // 
            // LookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 500);
            this.Controls.Add(this.lblSearchInstructions);
            this.Controls.Add(this.txtDisplayEmpInfo);
            this.Controls.Add(this.btnCancelLookup);
            this.Controls.Add(this.txtEnterID);
            this.Controls.Add(this.btnSearch);
            this.Name = "LookupForm";
            this.Text = "LookupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEnterID;
        private System.Windows.Forms.Button btnCancelLookup;
        private System.Windows.Forms.RichTextBox txtDisplayEmpInfo;
        private System.Windows.Forms.Label lblSearchInstructions;
    }
}