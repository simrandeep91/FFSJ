namespace FFSJ
{
    partial class frmViewSplitFileHistoryUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPartSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Size";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(175, 22);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 13);
            this.lblFileName.TabIndex = 2;
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.Location = new System.Drawing.Point(413, 22);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(0, 13);
            this.lblTotalSize.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Created Date";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Location = new System.Drawing.Point(175, 62);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(0, 13);
            this.lblCreateDate.TabIndex = 5;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPartName,
            this.dgvPartSize,
            this.dgvCreateDate});
            this.dgvHistory.Location = new System.Drawing.Point(12, 88);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.Size = new System.Drawing.Size(534, 196);
            this.dgvHistory.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(454, 290);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvPartName
            // 
            this.dgvPartName.DataPropertyName = "PartName";
            this.dgvPartName.HeaderText = "Part Name";
            this.dgvPartName.Name = "dgvPartName";
            this.dgvPartName.ReadOnly = true;
            this.dgvPartName.Width = 150;
            // 
            // dgvPartSize
            // 
            this.dgvPartSize.DataPropertyName = "PartSize";
            this.dgvPartSize.HeaderText = "Part Size";
            this.dgvPartSize.Name = "dgvPartSize";
            this.dgvPartSize.ReadOnly = true;
            this.dgvPartSize.Width = 150;
            // 
            // dgvCreateDate
            // 
            this.dgvCreateDate.DataPropertyName = "Create_Date";
            this.dgvCreateDate.HeaderText = "Create Date";
            this.dgvCreateDate.Name = "dgvCreateDate";
            this.dgvCreateDate.ReadOnly = true;
            this.dgvCreateDate.Width = 150;
            // 
            // frmViewSplitFileHistoryUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 339);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.lblCreateDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalSize);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewSplitFileHistoryUser";
            this.Text = "Split File History";
            this.Load += new System.EventHandler(this.frmViewSplitFileHistoryUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblTotalSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPartSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCreateDate;
    }
}