namespace FFSJ
{
    partial class frmViewSplitFileHistory
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
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvSplit = new System.Windows.Forms.DataGridView();
            this.dgvSplitFileId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSplittedFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvViewFiles = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gbDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSplit)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.dtpTo);
            this.gbDate.Controls.Add(this.label2);
            this.gbDate.Controls.Add(this.dtpFrom);
            this.gbDate.Controls.Add(this.label1);
            this.gbDate.Location = new System.Drawing.Point(162, 12);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(328, 39);
            this.gbDate.TabIndex = 0;
            this.gbDate.TabStop = false;
            this.gbDate.Text = "Date";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd-MMM-yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(212, 13);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(97, 20);
            this.dtpTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd-MMM-yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(72, 13);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(95, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "File";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(201, 65);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(126, 20);
            this.txtFile.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(349, 63);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(439, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvSplit
            // 
            this.dgvSplit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSplit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSplitFileId,
            this.dgvUserName,
            this.dgvFileName,
            this.dgvTotalSize,
            this.dgvCreateDate,
            this.dgvSplittedFiles,
            this.dgvViewFiles});
            this.dgvSplit.Location = new System.Drawing.Point(12, 90);
            this.dgvSplit.Name = "dgvSplit";
            this.dgvSplit.Size = new System.Drawing.Size(630, 183);
            this.dgvSplit.TabIndex = 5;
            this.dgvSplit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSplit_CellContentClick);
            // 
            // dgvSplitFileId
            // 
            this.dgvSplitFileId.DataPropertyName = "SplitFileId";
            this.dgvSplitFileId.HeaderText = "FileId";
            this.dgvSplitFileId.Name = "dgvSplitFileId";
            this.dgvSplitFileId.ReadOnly = true;
            this.dgvSplitFileId.Visible = false;
            // 
            // dgvUserName
            // 
            this.dgvUserName.DataPropertyName = "User_Name";
            this.dgvUserName.HeaderText = "User Name";
            this.dgvUserName.Name = "dgvUserName";
            this.dgvUserName.Width = 80;
            // 
            // dgvFileName
            // 
            this.dgvFileName.DataPropertyName = "FileName";
            this.dgvFileName.HeaderText = "File Name";
            this.dgvFileName.Name = "dgvFileName";
            this.dgvFileName.Width = 150;
            // 
            // dgvTotalSize
            // 
            this.dgvTotalSize.DataPropertyName = "TotalSize";
            this.dgvTotalSize.HeaderText = "Total Size";
            this.dgvTotalSize.Name = "dgvTotalSize";
            this.dgvTotalSize.Width = 85;
            // 
            // dgvCreateDate
            // 
            this.dgvCreateDate.DataPropertyName = "Create_Date";
            this.dgvCreateDate.HeaderText = "Create Date";
            this.dgvCreateDate.Name = "dgvCreateDate";
            this.dgvCreateDate.Width = 85;
            // 
            // dgvSplittedFiles
            // 
            this.dgvSplittedFiles.DataPropertyName = "SplitPartCount";
            this.dgvSplittedFiles.HeaderText = "Splitted Files";
            this.dgvSplittedFiles.Name = "dgvSplittedFiles";
            this.dgvSplittedFiles.Width = 60;
            // 
            // dgvViewFiles
            // 
            this.dgvViewFiles.HeaderText = "";
            this.dgvViewFiles.Name = "dgvViewFiles";
            this.dgvViewFiles.Text = "View Files";
            this.dgvViewFiles.UseColumnTextForLinkValue = true;
            // 
            // frmViewSplitFileHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 286);
            this.Controls.Add(this.dgvSplit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbDate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewSplitFileHistory";
            this.Text = "Split File History";
            this.Load += new System.EventHandler(this.frmViewSplitFileHistory_Load);
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSplit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvSplit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSplitFileId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSplittedFiles;
        private System.Windows.Forms.DataGridViewLinkColumn dgvViewFiles;
    }
}