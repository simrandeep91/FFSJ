namespace FFSJ
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSplitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSplitWizard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFastSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMerger = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMergeFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSplitHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMergeHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin,
            this.mnuSplitter,
            this.mnuMerger,
            this.mnuHistory,
            this.mnuUser});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManageUser});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuManageUser
            // 
            this.mnuManageUser.Name = "mnuManageUser";
            this.mnuManageUser.Size = new System.Drawing.Size(143, 22);
            this.mnuManageUser.Text = "Manage User";
            this.mnuManageUser.Click += new System.EventHandler(this.mnuManageUser_Click);
            // 
            // mnuSplitter
            // 
            this.mnuSplitter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSplitWizard,
            this.mnuFastSplit});
            this.mnuSplitter.Name = "mnuSplitter";
            this.mnuSplitter.Size = new System.Drawing.Size(56, 20);
            this.mnuSplitter.Text = "Splitter";
            // 
            // mnuSplitWizard
            // 
            this.mnuSplitWizard.Name = "mnuSplitWizard";
            this.mnuSplitWizard.Size = new System.Drawing.Size(136, 22);
            this.mnuSplitWizard.Text = "Split Wizard";
            this.mnuSplitWizard.Click += new System.EventHandler(this.mnuSplitWizard_Click);
            // 
            // mnuFastSplit
            // 
            this.mnuFastSplit.Name = "mnuFastSplit";
            this.mnuFastSplit.Size = new System.Drawing.Size(136, 22);
            this.mnuFastSplit.Text = "Fast Split";
            this.mnuFastSplit.Click += new System.EventHandler(this.mnuFastSplit_Click);
            // 
            // mnuMerger
            // 
            this.mnuMerger.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMergeFiles});
            this.mnuMerger.Name = "mnuMerger";
            this.mnuMerger.Size = new System.Drawing.Size(57, 20);
            this.mnuMerger.Text = "Merger";
            // 
            // mnuMergeFiles
            // 
            this.mnuMergeFiles.Name = "mnuMergeFiles";
            this.mnuMergeFiles.Size = new System.Drawing.Size(134, 22);
            this.mnuMergeFiles.Text = "Merge Files";
            this.mnuMergeFiles.Click += new System.EventHandler(this.mnuMergeFiles_Click);
            // 
            // mnuHistory
            // 
            this.mnuHistory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSplitHistory,
            this.mnuMergeHistory});
            this.mnuHistory.Name = "mnuHistory";
            this.mnuHistory.Size = new System.Drawing.Size(57, 20);
            this.mnuHistory.Text = "History";
            // 
            // mnuSplitHistory
            // 
            this.mnuSplitHistory.Name = "mnuSplitHistory";
            this.mnuSplitHistory.Size = new System.Drawing.Size(149, 22);
            this.mnuSplitHistory.Text = "Split History";
            this.mnuSplitHistory.Click += new System.EventHandler(this.mnuSplitHistory_Click);
            // 
            // mnuMergeHistory
            // 
            this.mnuMergeHistory.Name = "mnuMergeHistory";
            this.mnuMergeHistory.Size = new System.Drawing.Size(149, 22);
            this.mnuMergeHistory.Text = "Merge History";
            this.mnuMergeHistory.Click += new System.EventHandler(this.mnuMergeHistory_Click);
            // 
            // mnuUser
            // 
            this.mnuUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManageProfile,
            this.mnuChangePassword,
            this.mnuLogout});
            this.mnuUser.Name = "mnuUser";
            this.mnuUser.Size = new System.Drawing.Size(42, 20);
            this.mnuUser.Text = "User";
            // 
            // mnuManageProfile
            // 
            this.mnuManageProfile.Name = "mnuManageProfile";
            this.mnuManageProfile.Size = new System.Drawing.Size(168, 22);
            this.mnuManageProfile.Text = "Manage Profile";
            this.mnuManageProfile.Click += new System.EventHandler(this.mnuManageProfile_Click);
            // 
            // mnuChangePassword
            // 
            this.mnuChangePassword.Name = "mnuChangePassword";
            this.mnuChangePassword.Size = new System.Drawing.Size(168, 22);
            this.mnuChangePassword.Text = "Change Password";
            this.mnuChangePassword.Click += new System.EventHandler(this.mnuChangePassword_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(168, 22);
            this.mnuLogout.Text = "Logout";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 434);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuManageUser;
        private System.Windows.Forms.ToolStripMenuItem mnuSplitter;
        private System.Windows.Forms.ToolStripMenuItem mnuSplitWizard;
        private System.Windows.Forms.ToolStripMenuItem mnuFastSplit;
        private System.Windows.Forms.ToolStripMenuItem mnuMerger;
        private System.Windows.Forms.ToolStripMenuItem mnuMergeFiles;
        private System.Windows.Forms.ToolStripMenuItem mnuHistory;
        private System.Windows.Forms.ToolStripMenuItem mnuSplitHistory;
        private System.Windows.Forms.ToolStripMenuItem mnuMergeHistory;
        private System.Windows.Forms.ToolStripMenuItem mnuUser;
        private System.Windows.Forms.ToolStripMenuItem mnuManageProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePassword;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
    }
}