namespace FFSJ
{
    partial class frmFastSplitting
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
            this.gbSplitFiles = new System.Windows.Forms.GroupBox();
            this.nudParts = new System.Windows.Forms.NumericUpDown();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnCalculateSizeOfFile = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSizeOfFile = new System.Windows.Forms.GroupBox();
            this.txtApproximateLengthOfEachSplitFile = new System.Windows.Forms.TextBox();
            this.txtLengthOfOriginalFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.erpFastSplitting = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSplitFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParts)).BeginInit();
            this.gbSizeOfFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpFastSplitting)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSplitFiles
            // 
            this.gbSplitFiles.Controls.Add(this.nudParts);
            this.gbSplitFiles.Controls.Add(this.btnSplit);
            this.gbSplitFiles.Controls.Add(this.btnCalculateSizeOfFile);
            this.gbSplitFiles.Controls.Add(this.btnBrowse);
            this.gbSplitFiles.Controls.Add(this.txtSource);
            this.gbSplitFiles.Controls.Add(this.label3);
            this.gbSplitFiles.Controls.Add(this.label2);
            this.gbSplitFiles.Controls.Add(this.label1);
            this.gbSplitFiles.Location = new System.Drawing.Point(12, 12);
            this.gbSplitFiles.Name = "gbSplitFiles";
            this.gbSplitFiles.Size = new System.Drawing.Size(350, 113);
            this.gbSplitFiles.TabIndex = 0;
            this.gbSplitFiles.TabStop = false;
            this.gbSplitFiles.Text = "Split Files";
            // 
            // nudParts
            // 
            this.nudParts.Location = new System.Drawing.Point(137, 53);
            this.nudParts.Name = "nudParts";
            this.nudParts.Size = new System.Drawing.Size(32, 20);
            this.nudParts.TabIndex = 7;
            this.nudParts.ValueChanged += new System.EventHandler(this.nudParts_ValueChanged);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(253, 84);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 6;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnCalculateSizeOfFile
            // 
            this.btnCalculateSizeOfFile.Location = new System.Drawing.Point(6, 84);
            this.btnCalculateSizeOfFile.Name = "btnCalculateSizeOfFile";
            this.btnCalculateSizeOfFile.Size = new System.Drawing.Size(122, 23);
            this.btnCalculateSizeOfFile.TabIndex = 5;
            this.btnCalculateSizeOfFile.Text = "Calculate Size Of File";
            this.btnCalculateSizeOfFile.UseVisualStyleBackColor = true;
            this.btnCalculateSizeOfFile.Click += new System.EventHandler(this.btnCalculateSizeOfFile_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(253, 22);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(78, 24);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(169, 20);
            this.txtSource.TabIndex = 3;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parts";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File to be Splitted in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // gbSizeOfFile
            // 
            this.gbSizeOfFile.Controls.Add(this.txtApproximateLengthOfEachSplitFile);
            this.gbSizeOfFile.Controls.Add(this.txtLengthOfOriginalFile);
            this.gbSizeOfFile.Controls.Add(this.label5);
            this.gbSizeOfFile.Controls.Add(this.label4);
            this.gbSizeOfFile.Location = new System.Drawing.Point(12, 131);
            this.gbSizeOfFile.Name = "gbSizeOfFile";
            this.gbSizeOfFile.Size = new System.Drawing.Size(350, 100);
            this.gbSizeOfFile.TabIndex = 1;
            this.gbSizeOfFile.TabStop = false;
            this.gbSizeOfFile.Text = "Size Of File";
            this.gbSizeOfFile.Visible = false;
            // 
            // txtApproximateLengthOfEachSplitFile
            // 
            this.txtApproximateLengthOfEachSplitFile.Location = new System.Drawing.Point(212, 63);
            this.txtApproximateLengthOfEachSplitFile.Name = "txtApproximateLengthOfEachSplitFile";
            this.txtApproximateLengthOfEachSplitFile.ReadOnly = true;
            this.txtApproximateLengthOfEachSplitFile.Size = new System.Drawing.Size(100, 20);
            this.txtApproximateLengthOfEachSplitFile.TabIndex = 3;
            // 
            // txtLengthOfOriginalFile
            // 
            this.txtLengthOfOriginalFile.Location = new System.Drawing.Point(212, 22);
            this.txtLengthOfOriginalFile.Name = "txtLengthOfOriginalFile";
            this.txtLengthOfOriginalFile.ReadOnly = true;
            this.txtLengthOfOriginalFile.Size = new System.Drawing.Size(100, 20);
            this.txtLengthOfOriginalFile.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Approximate Length Of Each Split File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Length Of Original File";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // erpFastSplitting
            // 
            this.erpFastSplitting.ContainerControl = this;
            // 
            // frmFastSplitting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 239);
            this.Controls.Add(this.gbSizeOfFile);
            this.Controls.Add(this.gbSplitFiles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFastSplitting";
            this.Text = "Fast Splitting";
            this.Load += new System.EventHandler(this.frmFastSplitting_Load);
            this.gbSplitFiles.ResumeLayout(false);
            this.gbSplitFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParts)).EndInit();
            this.gbSizeOfFile.ResumeLayout(false);
            this.gbSizeOfFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpFastSplitting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSplitFiles;
        private System.Windows.Forms.NumericUpDown nudParts;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnCalculateSizeOfFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSizeOfFile;
        private System.Windows.Forms.TextBox txtApproximateLengthOfEachSplitFile;
        private System.Windows.Forms.TextBox txtLengthOfOriginalFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ErrorProvider erpFastSplitting;
    }
}