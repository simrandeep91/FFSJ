using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FFSJ
{
    public partial class frmViewSplitFileHistory : Form
    {
        SqlConnection con = new SqlConnection("Server=SHARAD-PC;uid=sa;pwd=student;database=FFSJ");
        string qry;
        DataTable dtbl;
        SqlDataAdapter dad;
        public static int SplitId;
        public frmViewSplitFileHistory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        


        private void frmViewSplitFileHistory_Load(object sender, EventArgs e)
        {
            
        }
        

        private void btnShow_Click(object sender, EventArgs e)
        {
            qry = "select  SplitFileMaster.SplitFileId,UserMaster.User_Name,SplitFileMaster.FileName,SplitFileMaster.TotalSize,SplitFileMaster.Create_Date,"
            + " count(SplitPartDetail.SplitFileId) as SplitPartCount from SplitFileMaster inner join SplitPartDetail on"
            + " SplitFileMaster.SplitFileId=SplitPartDetail.SplitFileId inner join UserMaster on SplitFileMaster.User_Id=UserMaster.User_Id"
            + " where SplitFileMaster.FileName like '%'+@search+'%' and SplitFileMaster.Create_Date between @date1 and @date2 "
            + " group by SplitFileMaster.FileName,SplitFileMaster.TotalSize,SplitFileMaster.Create_Date,UserMaster.User_Name,SplitFileMaster.SplitFileId";
            dad = new SqlDataAdapter(qry, con);
            dad.SelectCommand.Parameters.Add("@search", SqlDbType.VarChar).Value = txtFile.Text.ToString();
            dad.SelectCommand.Parameters.Add("@date1", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpFrom.Value).ToString("dd-MMM-yyyy");
            dad.SelectCommand.Parameters.Add("@date2", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpTo.Value).ToString("dd-MMM-yyyy");
            dtbl = new DataTable();
            dad.Fill(dtbl);
            dgvSplit.DataSource = dtbl;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFile.Clear();
            dtbl.Rows.Clear();
        }

        private void dgvSplit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSplit.Rows[e.RowIndex].Cells["dgvViewFiles"].Selected == true)
                {
                    
                    SplitId=Convert.ToInt32(dgvSplit.Rows[e.RowIndex].Cells["dgvSplitFileId"].Value);
                   // MessageBox.Show(Convert.ToString(SplitId));
                    frmViewSplitFileHistoryUser obj = new frmViewSplitFileHistoryUser();
                    obj.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"FFSJ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
