namespace FFSJ
{
    partial class frmWizardSplit
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.dgvWizardSplit = new System.Windows.Forms.DataGridView();
            this.dgvUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPartSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStartByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEndByte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRemovePart = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gbSplitFilePartSize = new System.Windows.Forms.GroupBox();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.txtPartSize = new System.Windows.Forms.TextBox();
            this.txtRemainingSize = new System.Windows.Forms.TextBox();
            this.txtTotalSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSplitFileName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartSplitting = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.erpWizardSplit = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWizardSplit)).BeginInit();
            this.gbSplitFilePartSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpWizardSplit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(122, 37);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(354, 20);
            this.txtSource.TabIndex = 1;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(507, 35);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFile.TabIndex = 2;
            this.btnBrowseFile.Text = "Browse File";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // dgvWizardSplit
            // 
            this.dgvWizardSplit.AllowUserToAddRows = false;
            this.dgvWizardSplit.AllowUserToDeleteRows = false;
            this.dgvWizardSplit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWizardSplit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvUserID,
            this.dgvFileName,
            this.dgvPartSize,
            this.dgvStartByte,
            this.dgvEndByte,
            this.dgvRemovePart});
            this.dgvWizardSplit.Location = new System.Drawing.Point(12, 76);
            this.dgvWizardSplit.Name = "dgvWizardSplit";
            this.dgvWizardSplit.ReadOnly = true;
            this.dgvWizardSplit.Size = new System.Drawing.Size(644, 164);
            this.dgvWizardSplit.TabIndex = 3;
            this.dgvWizardSplit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWizardSplit_CellContentClick);
            // 
            // dgvUserID
            // 
            this.dgvUserID.DataPropertyName = "UserId";
            this.dgvUserID.HeaderText = "User ID";
            this.dgvUserID.Name = "dgvUserID";
            this.dgvUserID.ReadOnly = true;
            this.dgvUserID.Visible = false;
            // 
            // dgvFileName
            // 
            this.dgvFileName.DataPropertyName = "FileName";
            this.dgvFileName.HeaderText = "File Name";
            this.dgvFileName.Name = "dgvFileName";
            this.dgvFileName.ReadOnly = true;
            // 
            // dgvPartSize
            // 
            this.dgvPartSize.DataPropertyName = "PartSize";
            this.dgvPartSize.HeaderText = "Part Size";
            this.dgvPartSize.Name = "dgvPartSize";
            this.dgvPartSize.ReadOnly = true;
            // 
            // dgvStartByte
            // 
            this.dgvStartByte.DataPropertyName = "StartByte";
            this.dgvStartByte.HeaderText = "StartByte";
            this.dgvStartByte.Name = "dgvStartByte";
            this.dgvStartByte.ReadOnly = true;
            // 
            // dgvEndByte
            // 
            this.dgvEndByte.DataPropertyName = "EndByte";
            this.dgvEndByte.HeaderText = "EndByte";
            this.dgvEndByte.Name = "dgvEndByte";
            this.dgvEndByte.ReadOnly = true;
            // 
            // dgvRemovePart
            // 
            this.dgvRemovePart.HeaderText = "";
            this.dgvRemovePart.Name = "dgvRemovePart";
            this.dgvRemovePart.ReadOnly = true;
            this.dgvRemovePart.Text = "Remove Part";
            this.dgvRemovePart.UseColumnTextForLinkValue = true;
            // 
            // gbSplitFilePartSize
            // 
            this.gbSplitFilePartSize.Controls.Add(this.btnAddPart);
            this.gbSplitFilePartSize.Controls.Add(this.txtPartSize);
            this.gbSplitFilePartSize.Controls.Add(this.txtRemainingSize);
            this.gbSplitFilePartSize.Controls.Add(this.txtTotalSize);
            this.gbSplitFilePartSize.Controls.Add(this.label6);
            this.gbSplitFilePartSize.Controls.Add(this.label5);
            this.gbSplitFilePartSize.Controls.Add(this.lblSplitFileName);
            this.gbSplitFilePartSize.Controls.Add(this.label3);
            this.gbSplitFilePartSize.Controls.Add(this.label2);
            this.gbSplitFilePartSize.Location = new System.Drawing.Point(12, 260);
            this.gbSplitFilePartSize.Name = "gbSplitFilePartSize";
            this.gbSplitFilePartSize.Size = new System.Drawing.Size(503, 180);
            this.gbSplitFilePartSize.TabIndex = 4;
            this.gbSplitFilePartSize.TabStop = false;
            this.gbSplitFilePartSize.Text = "Split File Part Size";
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(37, 151);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 8;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // txtPartSize
            // 
            this.txtPartSize.Location = new System.Drawing.Point(110, 110);
            this.txtPartSize.Name = "txtPartSize";
            this.txtPartSize.Size = new System.Drawing.Size(100, 20);
            this.txtPartSize.TabIndex = 7;
            this.txtPartSize.TextChanged += new System.EventHandler(this.txtPartSize_TextChanged);
            this.txtPartSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartSize_KeyPress);
            // 
            // txtRemainingSize
            // 
            this.txtRemainingSize.Location = new System.Drawing.Point(330, 25);
            this.txtRemainingSize.Name = "txtRemainingSize";
            this.txtRemainingSize.ReadOnly = true;
            this.txtRemainingSize.Size = new System.Drawing.Size(100, 20);
            this.txtRemainingSize.TabIndex = 6;
            // 
            // txtTotalSize
            // 
            this.txtTotalSize.Location = new System.Drawing.Point(110, 29);
            this.txtTotalSize.Name = "txtTotalSize";
            this.txtTotalSize.ReadOnly = true;
            this.txtTotalSize.Size = new System.Drawing.Size(100, 20);
            this.txtTotalSize.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Part Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Remaining Size";
            // 
            // lblSplitFileName
            // 
            this.lblSplitFileName.AutoSize = true;
            this.lblSplitFileName.Location = new System.Drawing.Point(129, 68);
            this.lblSplitFileName.Name = "lblSplitFileName";
            this.lblSplitFileName.Size = new System.Drawing.Size(27, 13);
            this.lblSplitFileName.TabIndex = 2;
            this.lblSplitFileName.Text = "*****";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Split File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Size";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnStartSplitting
            // 
            this.btnStartSplitting.Location = new System.Drawing.Point(533, 271);
            this.btnStartSplitting.Name = "btnStartSplitting";
            this.btnStartSplitting.Size = new System.Drawing.Size(89, 23);
            this.btnStartSplitting.TabIndex = 5;
            this.btnStartSplitting.Text = "Start Splitting";
            this.btnStartSplitting.UseVisualStyleBackColor = true;
            this.btnStartSplitting.Click += new System.EventHandler(this.btnStartSplitting_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(533, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // erpWizardSplit
            // 
            this.erpWizardSplit.ContainerControl = this;
            // 
            // frmWizardSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 456);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStartSplitting);
            this.Controls.Add(this.gbSplitFilePartSize);
            this.Controls.Add(this.dgvWizardSplit);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWizardSplit";
            this.Text = "Wizard Split";
            this.Load += new System.EventHandler(this.frmWizardSplit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWizardSplit)).EndInit();
            this.gbSplitFilePartSize.ResumeLayout(false);
            this.gbSplitFilePartSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpWizardSplit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.DataGridView dgvWizardSplit;
        private System.Windows.Forms.GroupBox gbSplitFilePartSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSplitFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.TextBox txtPartSize;
        private System.Windows.Forms.TextBox txtRemainingSize;
        private System.Windows.Forms.TextBox txtTotalSize;
        private System.Windows.Forms.Button btnStartSplitting;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider erpWizardSplit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPartSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStartByte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEndByte;
        private System.Windows.Forms.DataGridViewLinkColumn dgvRemovePart;
    }
}