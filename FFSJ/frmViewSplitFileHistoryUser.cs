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
    public partial class frmViewSplitFileHistoryUser : Form
    {
        SqlConnection con = new SqlConnection("Server=SHARAD-PC;uid=sa;pwd=student;database=FFSJ");
        SqlDataAdapter dad;
        string qry;
        string lqry;
        DataTable dtbl;
        DataTable ldtbl;
        public frmViewSplitFileHistoryUser()
        {
            InitializeComponent();
        }

        private void frmViewSplitFileHistoryUser_Load(object sender, EventArgs e)
        {
            try
            {
                dtbl = new DataTable();
                qry = "select partname,partsize,create_date from splitpartdetail where SplitFileId=@ID";
                dad = new SqlDataAdapter(qry, con);
                dad.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = frmViewSplitFileHistory.SplitId;
                dtbl = new DataTable();
                dad.Fill(dtbl);
                dgvHistory.DataSource = dtbl;
                lqry = "select filename,totalsize,create_date from splitfilemaster where SplitFileId=@id";
                dad = new SqlDataAdapter(lqry, con);
                dad.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = frmViewSplitFileHistory.SplitId;
                ldtbl = new DataTable();
                dad.Fill(ldtbl);
                lblCreateDate.Text = ldtbl.Rows[0]["Create_Date"].ToString();
                lblFileName.Text = ldtbl.Rows[0]["FileName"].ToString();
                lblTotalSize.Text = ldtbl.Rows[0]["TotalSize"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"FFSJ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
