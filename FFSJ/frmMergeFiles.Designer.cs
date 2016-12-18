namespace FFSJ
{
    partial class frmMergeFiles
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectSourceFolder = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.folderMergeFiles = new System.Windows.Forms.FolderBrowserDialog();
            this.destFolderMergeFiles = new System.Windows.Forms.FolderBrowserDialog();
            this.erpjoin = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlFile = new System.Windows.Forms.Panel();
            this.lblFileUnder = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStartJoining = new System.Windows.Forms.Button();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.txtSelectDestinationFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvFile = new System.Windows.Forms.DataGridView();
            this.dgvFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPartSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCreateDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erpjoin)).BeginInit();
            this.pnlFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Source Folder";
            // 
            // txtSelectSourceFolder
            // 
            this.txtSelectSourceFolder.Location = new System.Drawing.Point(124, 25);
            this.txtSelectSourceFolder.Name = "txtSelectSourceFolder";
            this.txtSelectSourceFolder.ReadOnly = true;
            this.txtSelectSourceFolder.Size = new System.Drawing.Size(470, 20);
            this.txtSelectSourceFolder.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(600, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(27, 68);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(124, 68);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // erpjoin
            // 
            this.erpjoin.ContainerControl = this;
            // 
            // pnlFile
            // 
            this.pnlFile.Controls.Add(this.lblFileUnder);
            this.pnlFile.Controls.Add(this.btnCancel);
            this.pnlFile.Controls.Add(this.btnStartJoining);
            this.pnlFile.Controls.Add(this.btnBrowse1);
            this.pnlFile.Controls.Add(this.txtSelectDestinationFolder);
            this.pnlFile.Controls.Add(this.label5);
            this.pnlFile.Controls.Add(this.dgvFile);
            this.pnlFile.Controls.Add(this.lblTotalSize);
            this.pnlFile.Controls.Add(this.label3);
            this.pnlFile.Controls.Add(this.lblCreateDate);
            this.pnlFile.Controls.Add(this.label2);
            this.pnlFile.Location = new System.Drawing.Point(12, 97);
            this.pnlFile.Name = "pnlFile";
            this.pnlFile.Size = new System.Drawing.Size(689, 340);
            this.pnlFile.TabIndex = 5;
            // 
            // lblFileUnder
            // 
            this.lblFileUnder.AutoSize = true;
            this.lblFileUnder.Location = new System.Drawing.Point(38, 34);
            this.lblFileUnder.Name = "lblFileUnder";
            this.lblFileUnder.Size = new System.Drawing.Size(0, 13);
            this.lblFileUnder.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(116, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStartJoining
            // 
            this.btnStartJoining.Location = new System.Drawing.Point(19, 296);
            this.btnStartJoining.Name = "btnStartJoining";
            this.btnStartJoining.Size = new System.Drawing.Size(75, 23);
            this.btnStartJoining.TabIndex = 25;
            this.btnStartJoining.Text = "Start Joining";
            this.btnStartJoining.UseVisualStyleBackColor = true;
            this.btnStartJoining.Click += new System.EventHandler(this.btnStartJoining_Click);
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(592, 250);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse1.TabIndex = 24;
            this.btnBrowse1.Text = "Browse";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click_1);
            // 
            // txtSelectDestinationFolder
            // 
            this.txtSelectDestinationFolder.Location = new System.Drawing.Point(179, 257);
            this.txtSelectDestinationFolder.Name = "txtSelectDestinationFolder";
            this.txtSelectDestinationFolder.ReadOnly = true;
            this.txtSelectDestinationFolder.Size = new System.Drawing.Size(407, 20);
            this.txtSelectDestinationFolder.TabIndex = 23;
            this.txtSelectDestinationFolder.TextChanged += new System.EventHandler(this.txtSelectDestinationFolder_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Select Destination Folder";
            // 
            // dgvFile
            // 
            this.dgvFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFileName,
            this.dgvPartSize,
            this.dgvCreateDateTime});
            this.dgvFile.Location = new System.Drawing.Point(33, 75);
            this.dgvFile.Name = "dgvFile";
            this.dgvFile.Size = new System.Drawing.Size(598, 159);
            this.dgvFile.TabIndex = 21;
            // 
            // dgvFileName
            // 
            this.dgvFileName.DataPropertyName = "FileName";
            this.dgvFileName.HeaderText = "FileName";
            this.dgvFileName.Name = "dgvFileName";
            this.dgvFileName.ReadOnly = true;
            this.dgvFileName.Width = 200;
            // 
            // dgvPartSize
            // 
            this.dgvPartSize.DataPropertyName = "PartSize";
            this.dgvPartSize.HeaderText = "Part Size (in Bytes)";
            this.dgvPartSize.Name = "dgvPartSize";
            this.dgvPartSize.ReadOnly = true;
            this.dgvPartSize.Width = 150;
            // 
            // dgvCreateDateTime
            // 
            this.dgvCreateDateTime.DataPropertyName = "CreateDate";
            this.dgvCreateDateTime.HeaderText = "Create Date/Time";
            this.dgvCreateDateTime.Name = "dgvCreateDateTime";
            this.dgvCreateDateTime.ReadOnly = true;
            this.dgvCreateDateTime.Width = 200;
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.Location = new System.Drawing.Point(568, 1);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(0, 13);
            this.lblTotalSize.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total Size";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Location = new System.Drawing.Point(126, 1);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(0, 13);
            this.lblCreateDate.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Create Date";
            // 
            // frmMergeFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 449);
            this.Controls.Add(this.pnlFile);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSelectSourceFolder);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMergeFiles";
            this.Text = "File Join";
            this.Load += new System.EventHandler(this.frmMergeFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpjoin)).EndInit();
            this.pnlFile.ResumeLayout(false);
            this.pnlFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectSourceFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.FolderBrowserDialog folderMergeFiles;
        private System.Windows.Forms.FolderBrowserDialog destFolderMergeFiles;
        private System.Windows.Forms.ErrorProvider erpjoin;
        private System.Windows.Forms.Panel pnlFile;
        private System.Windows.Forms.Label lblFileUnder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStartJoining;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.TextBox txtSelectDestinationFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPartSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCreateDateTime;
        private System.Windows.Forms.Label lblTotalSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label label2;
    }
}