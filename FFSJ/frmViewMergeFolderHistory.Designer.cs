namespace FFSJ
{
    partial class frmViewMergeFolderHistory
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMerge = new System.Windows.Forms.DataGridView();
            this.dgvMergeFolderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMergeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNoOfParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvViewFiles = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gbDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerge)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDate
            // 
            this.gbDate.Controls.Add(this.dtpTo);
            this.gbDate.Controls.Add(this.label2);
            this.gbDate.Controls.Add(this.dtpFrom);
            this.gbDate.Controls.Add(this.label1);
            this.gbDate.Location = new System.Drawing.Point(156, 12);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(328, 39);
            this.gbDate.TabIndex = 1;
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
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(423, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(333, 67);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(185, 69);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(126, 20);
            this.txtFolder.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Folder";
            // 
            // dgvMerge
            // 
            this.dgvMerge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMerge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMergeFolderId,
            this.dgvUserName,
            this.dgvFolderName,
            this.dgvSize,
            this.dgvMergeDate,
            this.dgvNoOfParts,
            this.dgvViewFiles});
            this.dgvMerge.Location = new System.Drawing.Point(12, 95);
            this.dgvMerge.Name = "dgvMerge";
            this.dgvMerge.Size = new System.Drawing.Size(628, 200);
            this.dgvMerge.TabIndex = 9;
            this.dgvMerge.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvMergeFolderId
            // 
            this.dgvMergeFolderId.DataPropertyName = "MergeFolderId";
            this.dgvMergeFolderId.HeaderText = "Merge Folder Id";
            this.dgvMergeFolderId.Name = "dgvMergeFolderId";
            this.dgvMergeFolderId.Visible = false;
            // 
            // dgvUserName
            // 
            this.dgvUserName.DataPropertyName = "User_Name";
            this.dgvUserName.HeaderText = "User Name";
            this.dgvUserName.Name = "dgvUserName";
            this.dgvUserName.ReadOnly = true;
            this.dgvUserName.Width = 90;
            // 
            // dgvFolderName
            // 
            this.dgvFolderName.DataPropertyName = "FolderName";
            this.dgvFolderName.HeaderText = "Folder Name";
            this.dgvFolderName.Name = "dgvFolderName";
            this.dgvFolderName.ReadOnly = true;
            this.dgvFolderName.Width = 130;
            // 
            // dgvSize
            // 
            this.dgvSize.DataPropertyName = "TotalSize";
            this.dgvSize.HeaderText = "Size";
            this.dgvSize.Name = "dgvSize";
            this.dgvSize.ReadOnly = true;
            this.dgvSize.Width = 85;
            // 
            // dgvMergeDate
            // 
            this.dgvMergeDate.DataPropertyName = "Create_Date";
            this.dgvMergeDate.HeaderText = "Merge Date";
            this.dgvMergeDate.Name = "dgvMergeDate";
            this.dgvMergeDate.ReadOnly = true;
            this.dgvMergeDate.Width = 85;
            // 
            // dgvNoOfParts
            // 
            this.dgvNoOfParts.DataPropertyName = "NoofParts";
            this.dgvNoOfParts.HeaderText = "No. Of Parts";
            this.dgvNoOfParts.Name = "dgvNoOfParts";
            this.dgvNoOfParts.ReadOnly = true;
            this.dgvNoOfParts.Width = 65;
            // 
            // dgvViewFiles
            // 
            this.dgvViewFiles.HeaderText = "";
            this.dgvViewFiles.Name = "dgvViewFiles";
            this.dgvViewFiles.Text = "View Files";
            this.dgvViewFiles.UseColumnTextForLinkValue = true;
            // 
            // frmViewMergeFolderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 327);
            this.Controls.Add(this.dgvMerge);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbDate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewMergeFolderHistory";
            this.Text = "Merge History";
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMerge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMergeFolderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFolderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMergeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNoOfParts;
        private System.Windows.Forms.DataGridViewLinkColumn dgvViewFiles;
    }
}