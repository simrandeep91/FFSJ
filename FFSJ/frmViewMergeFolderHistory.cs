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
    public partial class frmViewMergeFolderHistory : Form
    {
        SqlConnection con = new SqlConnection("Server=SHARAD-PC;uid=sa;pwd=student;database=FFSJ");
        string qry;
        DataTable dtbl;
        SqlDataAdapter dad;
        public static int MergeId;
        public frmViewMergeFolderHistory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMerge.Rows[e.RowIndex].Cells["dgvViewFiles"].Selected == true)
                {

                    MergeId = Convert.ToInt32(dgvMerge.Rows[e.RowIndex].Cells["dgvMergeFolderId"].Value);
                    // MessageBox.Show(Convert.ToString(SplitId));
                    frmViewMergeFolderHistoryUser obj = new frmViewMergeFolderHistoryUser();
                    obj.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFolder.Clear();
            dtbl.Rows.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            qry = "select  MergeFolderMaster.MergeFolderId,UserMaster.User_Name,MergeFolderMaster.FolderName,MergeFolderMaster.TotalSize,MergeFolderMaster.Create_Date,"
           + " count(MergeFolderDetail.MergeFolderId) as NoofParts from MergeFolderMaster inner join MergeFolderDetail on"
           + " MergeFolderMaster.MergeFolderId=MergeFolderDetail.MergeFolderId inner join UserMaster on MergeFolderMaster.User_Id=UserMaster.User_Id"
           + " where MergeFolderMaster.FolderName like '%'+@search+'%' and MergeFolderMaster.Create_Date between @date1 and @date2 "
           + " group by MergeFolderMaster.FolderName,MergeFolderMaster.TotalSize,MergeFolderMaster.Create_Date,UserMaster.User_Name,MergeFolderMaster.MergeFolderId";
            dad = new SqlDataAdapter(qry, con);
            dad.SelectCommand.Parameters.Add("@search", SqlDbType.VarChar).Value = txtFolder.Text.ToString();
            dad.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpFrom.Value).ToString("dd-MMM-yyyy");
            dad.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpTo.Value).ToString("dd-MMM-yyyy");
            dtbl = new DataTable();
            dad.Fill(dtbl);
            dgvMerge.DataSource = dtbl;
        }
    }
}
