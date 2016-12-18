namespace FFSJ
{
    partial class frmViewMergeFolderHistoryUser
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvHistory1 = new System.Windows.Forms.DataGridView();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPartSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(457, 295);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvHistory1
            // 
            this.dgvHistory1.AllowUserToAddRows = false;
            this.dgvHistory1.AllowUserToDeleteRows = false;
            this.dgvHistory1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFileName,
            this.dgvPartSize,
            this.dgvCreateDate});
            this.dgvHistory1.Location = new System.Drawing.Point(15, 93);
            this.dgvHistory1.Name = "dgvHistory1";
            this.dgvHistory1.ReadOnly = true;
            this.dgvHistory1.Size = new System.Drawing.Size(534, 196);
            this.dgvHistory1.TabIndex = 14;
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Location = new System.Drawing.Point(178, 67);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(0, 13);
            this.lblCreateDate.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Created Date";
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.Location = new System.Drawing.Point(416, 27);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(0, 13);
            this.lblTotalSize.TabIndex = 11;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(178, 27);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 13);
            this.lblFileName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "File Name";
            // 
            // dgvFileName
            // 
            this.dgvFileName.DataPropertyName = "FileName";
            this.dgvFileName.HeaderText = "File Name";
            this.dgvFileName.Name = "dgvFileName";
            this.dgvFileName.ReadOnly = true;
            this.dgvFileName.Width = 150;
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
            // frmViewMergeFolderHistoryUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 342);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvHistory1);
            this.Controls.Add(this.lblCreateDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalSize);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmViewMergeFolderHistoryUser";
            this.Text = "frmViewMergeFolderHistoryUser";
            this.Load += new System.EventHandler(this.frmViewMergeFolderHistoryUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvHistory1;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalSize;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPartSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCreateDate;
    }
}