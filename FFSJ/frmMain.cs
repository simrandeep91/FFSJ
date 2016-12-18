using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FFSJ
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            if (frmLogin.UserType.ToLower() == "user")
            {
                mnuAdmin.Visible = false;
                mnuHistory.Visible = false;
            }
        }

        private void mnuChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword obj = new frmChangePassword();
            obj.MdiParent = this;
            obj.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void mnuManageProfile_Click(object sender, EventArgs e)
        {
            frmManageProfile obj = new frmManageProfile();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mnuManageUser_Click(object sender, EventArgs e)
        {
            frmManageUser obj = new frmManageUser();
            obj.MdiParent = this;
            obj.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuSplitWizard_Click(object sender, EventArgs e)
        {
            frmWizardSplit obj = new frmWizardSplit();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mnuFastSplit_Click(object sender, EventArgs e)
        {
            frmFastSplitting obj = new frmFastSplitting();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mnuMergeFiles_Click(object sender, EventArgs e)
        {
            frmMergeFiles obj = new frmMergeFiles();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mnuSplitHistory_Click(object sender, EventArgs e)
        {
            frmViewSplitFileHistory obj = new frmViewSplitFileHistory();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mnuMergeHistory_Click(object sender, EventArgs e)
        {
            frmViewMergeFolderHistory obj = new frmViewMergeFolderHistory();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin obj = new frmLogin();
            obj.Show();
        }
    }
}
