using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace FFSJ
{
    public partial class frmFastSplitting : Form
    {
        SqlConnection con = new SqlConnection("Server=SHARAD-PC;uid=sa;pwd=student;database=FFSJ");
        SqlCommand cmd;
        string strpath = "";
        static int intPart = 1;
        static int intYes = 0;
        int intStartByte = 0;
        int intEndByte = 0;
        int intPreviousEndByte = 0;
        static int intRemain = 0;
        static int intId = 0;
        string FileName = "";
        static int intMaxId;
        DataTable dtbltemp;
        public frmFastSplitting()
        {
            InitializeComponent();
            addtemptable();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void addtemptable()
        {
            try
            {
                dtbltemp = new DataTable();
                dtbltemp.Columns.Add("UserID", typeof(int));
                dtbltemp.Columns.Add("FileName", typeof(string));
                dtbltemp.Columns.Add("PartSize", typeof(int));
                dtbltemp.Columns.Add("StartByte", typeof(int));
                dtbltemp.Columns.Add("EndByte", typeof(int));
                dtbltemp.PrimaryKey = new DataColumn[] { dtbltemp.Columns["UserID"] };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calc()
        {
            FileStream fs = new FileStream(txtSource.Text, FileMode.Open, FileAccess.Read);
            txtLengthOfOriginalFile.Text = "" + fs.Length;
            txtApproximateLengthOfEachSplitFile.Text = Convert.ToString(Convert.ToInt32(txtLengthOfOriginalFile.Text) / Convert.ToInt32(nudParts.Value));

        }
        private void btnCalculateSizeOfFile_Click(object sender, EventArgs e)
        {
            if (txtSource.Text.Trim() == "")
            {
                erpFastSplitting.SetError(txtSource, "choose the filename");
                MessageBox.Show(erpFastSplitting.GetError(txtSource), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSource.Focus();
            }
            else if (nudParts.Value == 0 || nudParts.Value == 1)
            {
                erpFastSplitting.SetError(nudParts, "select appropriate number to split");
                MessageBox.Show(erpFastSplitting.GetError(nudParts), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudParts.Focus();
            }
            else
            {

                gbSizeOfFile.Visible = true;
                calc();
            }
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog2.ShowDialog())
            {
                txtSource.Text = openFileDialog2.FileName;
                strpath = openFileDialog2.FileName;
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (txtSource.Text.Trim() == "")
            {
                erpFastSplitting.SetError(txtSource, "choose the filename");
                MessageBox.Show(erpFastSplitting.GetError(txtSource), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSource.Focus();
            }
            else if (nudParts.Value == 0 || nudParts.Value == 1)
            {
                erpFastSplitting.SetError(nudParts, "select appropriate number to split");
                MessageBox.Show(erpFastSplitting.GetError(nudParts), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudParts.Focus();
            }
            else
            {
                calc();
                if (txtSource.Text == "")
                {
                    MessageBox.Show("File not selected", "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {

                        string inputfile = txtSource.Text;
                        FileStream fs = new FileStream(inputfile, FileMode.Open, FileAccess.Read);
                        string Filpath = Application.StartupPath;
                        string Path = Filpath.Substring(0, Filpath.LastIndexOf("bin"));

                        Path += @"\SplittedFiles";
                        if (Directory.Exists(Path) == false)
                        {
                            Directory.CreateDirectory(Path);
                        }
                        Path += @"\" + inputfile.Substring(inputfile.LastIndexOf(@"\") + 1, (inputfile.LastIndexOf(".") - inputfile.LastIndexOf(@"\") - 1));
                        if (Directory.Exists(Path) == false)
                        {
                            Directory.CreateDirectory(Path);
                            intYes = 1;
                        }
                        else
                        {
                            string[] finame = Directory.GetFiles(Path);
                            if (DialogResult.Yes == MessageBox.Show("Do you want to delete the exsisting file", "FFSJ", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                            {
                                foreach (string strFile in finame)
                                {
                                    File.Delete(strFile);
                                }
                                intYes = 1;
                            }
                            else
                            {
                                intYes = 0;
                            }
                        }
                        if (intYes == 1)
                        {


                            intPart = 1;
                            intStartByte = 0;
                            intEndByte = 0;
                            intPreviousEndByte = 0;
                            intRemain = 0;
                            intId = 1;

                            for (int j = 0; j < Convert.ToInt32(nudParts.Value) - 1; j++)
                            {

                                intStartByte = intEndByte + 1;
                                intEndByte = Convert.ToInt32(txtApproximateLengthOfEachSplitFile.Text) + intPreviousEndByte;

                                FileName = strpath.Substring(strpath.LastIndexOf(@"\") + 1, (strpath.LastIndexOf(".") - strpath.LastIndexOf(@"\") - 1)) + ".part" + Convert.ToString(intPart) + strpath.Substring(strpath.LastIndexOf(".")) + ".tmp";
                                dtbltemp.Rows.Add(intId, FileName, Convert.ToInt32(txtApproximateLengthOfEachSplitFile.Text), intStartByte, intEndByte);
                                intPreviousEndByte = intEndByte;
                                intPart++;
                                intId = intId + 1;
                            }
                            intStartByte = intEndByte + 1;
                            intEndByte = Convert.ToInt32(txtLengthOfOriginalFile.Text);
                            intRemain = Convert.ToInt32(txtLengthOfOriginalFile.Text) - ((Convert.ToInt32(nudParts.Value) - 1) * Convert.ToInt32(txtApproximateLengthOfEachSplitFile.Text));
                            FileName = strpath.Substring(strpath.LastIndexOf(@"\") + 1, (strpath.LastIndexOf(".") - strpath.LastIndexOf(@"\") - 1)) + ".part" + Convert.ToString(intPart) + strpath.Substring(strpath.LastIndexOf(".")) + ".tmp";
                            dtbltemp.Rows.Add(intId, FileName, intRemain, intStartByte, intEndByte);

                            for (int i = 0; i < dtbltemp.Rows.Count; i++)
                            {
                                FileStream outputFile = new FileStream(Path + "\\" + dtbltemp.Rows[i]["FileName"].ToString(), FileMode.Create, FileAccess.Write);
                                int byteRead = 0;
                                byte[] Buffer = new byte[Convert.ToInt32(dtbltemp.Rows[i]["EndByte"].ToString())];
                                if ((byteRead = fs.Read(Buffer, Convert.ToInt32(dtbltemp.Rows[i]["StartByte"].ToString()), Convert.ToInt32(dtbltemp.Rows[i]["EndByte"].ToString()) - Convert.ToInt32(dtbltemp.Rows[i]["StartByte"].ToString()))) > 0)
                                {
                                    outputFile.Write(Buffer, Convert.ToInt32(dtbltemp.Rows[i]["StartByte"].ToString()), byteRead);
                                }
                                outputFile.Close();
                            }
                            InsertSplitMaster();
                            MaxId();
                            InsertSplitPart();
                            MessageBox.Show("Splitted File Save On Location " + Path);
                            this.Close();
                            intPart = 1;
                            dtbltemp.Rows.Clear();

                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void InsertSplitMaster()
        {
            string qry = "insert into SplitFileMaster(FileName,TotalSize,Create_Date,User_Id)Values(@filename,@totalsize,@createdate,@userid)";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = frmLogin.UserId;
            cmd.Parameters.Add("@filename", SqlDbType.VarChar).Value = strpath.Substring(strpath.LastIndexOf(@"\") + 1, (strpath.LastIndexOf(".") - strpath.LastIndexOf(@"\") - 1));
            cmd.Parameters.Add("@totalsize", SqlDbType.Int).Value = txtLengthOfOriginalFile.Text;
            cmd.Parameters.Add("@createdate", SqlDbType.DateTime).Value = Convert.ToDateTime(System.DateTime.Now).ToString("dd-MMM-yyyy");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void MaxId()
        {
            String qry = "select max(SplitFileId) from SplitFileMaster";
            cmd = new SqlCommand(qry, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            intMaxId = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();


        }
        private void InsertSplitPart()
        {
            for (int i = 0; i < dtbltemp.Rows.Count; i++)
            {
                String qry = "insert into splitpartdetail(SplitFileId,PartName,PartSize,Create_Date) Values(@splitfile_id,@part_name,@part_size,@createdate)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.Add("@splitfile_id", SqlDbType.Int).Value = intMaxId;
                cmd.Parameters.Add("@part_name", SqlDbType.VarChar).Value = dtbltemp.Rows[i]["FileName"].ToString();
                cmd.Parameters.Add("@part_size", SqlDbType.Int).Value = Convert.ToInt32(dtbltemp.Rows[i]["PartSize"].ToString());
                cmd.Parameters.Add("@createdate", SqlDbType.DateTime).Value = Convert.ToDateTime(System.DateTime.Now).ToString("dd-MMM-yyyy");
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            erpFastSplitting.Clear();
        }

        private void nudParts_ValueChanged(object sender, EventArgs e)
        {
            erpFastSplitting.Clear();
        }

        private void frmFastSplitting_Load(object sender, EventArgs e)
        {

        }
    }
}
