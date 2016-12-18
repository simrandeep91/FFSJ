using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FFSJ
{
    public partial class frmViewMergeFolderHistoryUser : Form
    {
        SqlConnection con = new SqlConnection("Server=SHARAD-PC;uid=sa;pwd=student;database=FFSJ");
        SqlDataAdapter dad;
        string qry;
        string lqry;
        DataTable dtbl;
        DataTable ldtbl;
        
        public frmViewMergeFolderHistoryUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewMergeFolderHistoryUser_Load(object sender, EventArgs e)
        {
            try
            {
                dtbl = new DataTable();
                qry = "select filename,partsize,create_date from mergefolderdetail where MergeFolderId=@ID";
                dad = new SqlDataAdapter(qry, con);
                dad.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = frmViewMergeFolderHistory.MergeId;
                dtbl = new DataTable();
                dad.Fill(dtbl);
                dgvHistory1.DataSource = dtbl;
                lqry = "select foldername,totalsize,create_date from mergefoldermaster where mergefolderId=@id";
                dad = new SqlDataAdapter(lqry, con);
                dad.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = frmViewMergeFolderHistory.MergeId;
                ldtbl = new DataTable();
                dad.Fill(ldtbl);
                lblCreateDate.Text = ldtbl.Rows[0]["Create_Date"].ToString();
                lblFileName.Text = ldtbl.Rows[0]["FolderName"].ToString();
                lblTotalSize.Text = ldtbl.Rows[0]["TotalSize"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
