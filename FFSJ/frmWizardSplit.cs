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
    public partial class frmWizardSplit : Form
    {
        string strpath;
       static int intPart = 1;
       static string strSplitFile = "";
       int intStartByte = 0;
       int intEndByte = 0;
       int intPreviousEndByte = 0;
       static int intRemain = 0;
       static int intId = 0;
       static int intPartSizeRemove = 0;
       static int intPartId;
        static int intMaxId;
        static int intYes = 0;
        SqlConnection con = new SqlConnection("Server=SHARAD-PC;uid=sa;pwd=student;database=FFSJ");
        SqlCommand cmd;

        DataTable dtbltemp;
        public frmWizardSplit()
        {
            InitializeComponent();
            addtemptable();
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
        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                txtSource.Text = openFileDialog1.FileName;
                strpath = openFileDialog1.FileName;
                FileStream fs = new FileStream(txtSource.Text,FileMode.Open,FileAccess.Read);
                txtTotalSize.Text = "" + fs.Length;
                txtRemainingSize.Text = "" + fs.Length;
                lblSplitFileName.Text = strpath.Substring(strpath.LastIndexOf(@"\") + 1, (strpath.LastIndexOf(".") - strpath.LastIndexOf(@"\") - 1)) + ".part1" + strpath.Substring(strpath.LastIndexOf(".")) + ".tmp";
            }
        }

        private void frmWizardSplit_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(txtRemainingSize.Text) - Convert.ToInt32(txtPartSize.Text);
                if (txtPartSize.Text.Trim() == "")
                {
                    erpWizardSplit.SetError(txtPartSize, "enter the partsize");
                    MessageBox.Show(erpWizardSplit.GetError(txtPartSize), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPartSize.Focus();
                }
                else if (txtPartSize.Text == txtTotalSize.Text)
                {
                    erpWizardSplit.SetError(txtPartSize, "enter correct partsize");
                    MessageBox.Show(erpWizardSplit.GetError(txtPartSize), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPartSize.Focus();
                }
                else if (Convert.ToInt32(txtPartSize.Text) <= 0 || (temp) < 0)
                {
                    erpWizardSplit.SetError(txtPartSize, "enter correct partsize");
                    MessageBox.Show(erpWizardSplit.GetError(txtPartSize), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPartSize.Focus();
                }
                else
                {
                    if (dtbltemp.Rows.Count == 0)
                    {
                        intPart = 1;
                        strSplitFile = "";
                        intStartByte = 0;
                        intEndByte = 0;
                        intPreviousEndByte = 0;
                        intRemain = 0;
                        intId = 0;
                        intPartSizeRemove = 0;
                        intPartId = 0;
                    }
                    intId = intId + 1;
                    intStartByte = intEndByte + 1;
                    intEndByte = Convert.ToInt32(txtPartSize.Text) + intPreviousEndByte;
                    dtbltemp.Rows.Add(intId, lblSplitFileName.Text, txtPartSize.Text, intStartByte, intEndByte);
                    intPreviousEndByte = intEndByte;
                    dgvWizardSplit.DataSource = dtbltemp;
                    intPart++;
                    txtRemainingSize.Text = Convert.ToString(Convert.ToInt32(txtRemainingSize.Text) - Convert.ToInt32(txtPartSize.Text));
                    strSplitFile= strpath.Substring(strpath.LastIndexOf(@"\") + 1, (strpath.LastIndexOf(".") - strpath.LastIndexOf(@"\") - 1)) + ".part" + Convert.ToString(intPart) + strpath.Substring(strpath.LastIndexOf(".")) + ".tmp";
                    lblSplitFileName.Text = strSplitFile;
                    txtPartSize.Text = "";
                    txtPartSize.Focus();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"FFSJ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvWizardSplit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvWizardSplit.Rows[e.RowIndex].Cells["dgvRemovePart"].Selected == true)
                {

                    DataTable dtblLoc = dtbltemp;
                    for (int intcount = 0; intcount < dtblLoc.Rows.Count; intcount++)
                    {
                        if (dgvWizardSplit.Rows[e.RowIndex].Cells["dgvRemovePart"].Selected == true)
                        {
                            if (dgvWizardSplit.Rows[e.RowIndex].Cells["dgvUserID"].Value.ToString() == dtblLoc.Rows[intcount]["UserID"].ToString())
                            {
                                intId = intPart = intPartId = Convert.ToInt32(dtblLoc.Rows[intcount]["UserID"].ToString());
                                intPartSizeRemove = Convert.ToInt32(dtblLoc.Rows[intcount]["PartSize"].ToString());
                                dtblLoc.Rows.RemoveAt(intcount);
                                txtRemainingSize.Text = "" + (Convert.ToInt32(txtRemainingSize.Text) + intPartSizeRemove);
                                break;
                            }
                        }
                    }
                    addtemptable();
                    for (int i = 0; i < dtblLoc.Rows.Count; i++)
                    {
                        if (intPartId > Convert.ToInt32(dtblLoc.Rows[i]["UserID"].ToString()))
                        {
                            dtbltemp.Rows.Add(Convert.ToInt32(dtblLoc.Rows[i]["UserID"].ToString()), dtblLoc.Rows[i]["FileName"].ToString(), Convert.ToInt32(dtblLoc.Rows[i]["PartSize"].ToString()), Convert.ToInt32(dtblLoc.Rows[i]["StartByte"].ToString()), Convert.ToInt32(dtblLoc.Rows[i]["EndByte"].ToString()));
                            intPreviousEndByte = Convert.ToInt32(dtblLoc.Rows[i]["EndByte"].ToString());
                            intStartByte = Convert.ToInt32(dtblLoc.Rows[i]["StartByte"].ToString());
                            intEndByte = Convert.ToInt32(dtblLoc.Rows[i]["EndByte"].ToString());
                        }
                        else
                        {
                            intStartByte = Convert.ToInt32(dtblLoc.Rows[i]["StartByte"].ToString()) - intPartSizeRemove;
                            intEndByte = Convert.ToInt32(dtblLoc.Rows[i]["EndByte"].ToString()) - intPartSizeRemove;
                            strSplitFile = strpath.Substring(strpath.LastIndexOf(@"\") + 1, (strpath.LastIndexOf(".") - strpath.LastIndexOf(@"\") - 1)) + ".part" + Convert.ToString(intPart) + strpath.Substring(strpath.LastIndexOf(".")) + ".tmp";
                            lblSplitFileName.Text = strSplitFile;
                            dtbltemp.Rows.Add(intId, lblSplitFileName.Text, Convert.ToInt32(dtblLoc.Rows[i]["PartSize"].ToString()), intStartByte, intEndByte);
                            intId++;
                            intPart++;
                            intPreviousEndByte = intEndByte;
                        }
                    }
                    intId--;
                    strSplitFile = strpath.Substring(strpath.LastIndexOf(@"\") + 1, (strpath.LastIndexOf(".") - strpath.LastIndexOf(@"\") - 1)) + ".part" + Convert.ToString(intPart) + strpath.Substring(strpath.LastIndexOf(".")) + ".tmp";
                    lblSplitFileName.Text = strSplitFile;
                    dgvWizardSplit.DataSource = dtbltemp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStartSplitting_Click(object sender, EventArgs e)
        {
            if (txtSource.Text == "")
            {
                MessageBox.Show("File not selected", "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtbltemp.Rows.Count == 0)
            {
                MessageBox.Show("There should be atleast two files to split", "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToInt32(txtRemainingSize.Text) != 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want remaining part of file to be one part", "FFSJ", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    intId++;
                    intEndByte = Convert.ToInt32(txtRemainingSize.Text) + intPreviousEndByte;
                    intStartByte = intPreviousEndByte + 1;
                    
                    dtbltemp.Rows.Add(intId, lblSplitFileName.Text,txtRemainingSize.Text ,intStartByte, intEndByte);
                    intPreviousEndByte = intEndByte;
                    intStartByte = intEndByte + 1;
                    intPart++;
                    strSplitFile = strpath.Substring(strpath.LastIndexOf(@"\") + 1, (strpath.LastIndexOf(".") - strpath.LastIndexOf(@"\") - 1)) + ".part" + Convert.ToString(intPart) + strpath.Substring(strpath.LastIndexOf(".")) + ".tmp";
                    lblSplitFileName.Text = strSplitFile;
                    txtPartSize.Text = "";
                    txtRemainingSize.Text = "0";
                    Split();
                }
            }
            else
            {
                Split();
            }
        }
        private void Split()
        {
            try
            {
                
                string inputfile = txtSource.Text;
                FileStream fs = new FileStream(inputfile, FileMode.Open, FileAccess.Read);
                string Filpath=Application.StartupPath;
                string Path = Filpath.Substring(0, Filpath.LastIndexOf("bin"));
                
                Path += @"\SplittedFiles";
                if (Directory.Exists(Path)==false)
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
                    if(DialogResult.Yes==MessageBox.Show("Do you want to delete the exsisting file","FFSJ",MessageBoxButtons.YesNo,MessageBoxIcon.Information))
                    {
                        foreach(string strFile in finame)
                        {
                            File.Delete(strFile);
                        }
                        intYes=1;
                    }
                    else
                    {
                        intYes=0;
                    }
                }
                if(intYes==1)
                {
                    for(int i=0;i<dtbltemp.Rows.Count;i++)
                    { 
                        FileStream outputFile=new FileStream(Path+"\\"+dtbltemp.Rows[i]["FileName"].ToString(),FileMode.Create,FileAccess.Write);
                        int byteRead=0;
                        byte[] Buffer= new byte[Convert.ToInt32(dtbltemp.Rows[i]["EndByte"].ToString())];
                        
                        if((byteRead=fs.Read(Buffer,Convert.ToInt32(dtbltemp.Rows[i]["StartByte"].ToString()),Convert.ToInt32(dtbltemp.Rows[i]["EndByte"].ToString())-Convert.ToInt32(dtbltemp.Rows[i]["StartByte"].ToString())))>0)
                        {
                            outputFile.Write(Buffer,Convert.ToInt32(dtbltemp.Rows[i]["StartByte"].ToString()),byteRead);
                        }
                        outputFile.Close();
                    }
                        InsertSplitMaster();
                        MaxId();
                        InsertSplitPart();
                        MessageBox.Show("Splitted File Save On Location "+Path);
                        this.Close();
                        intPart=1;
                        strSplitFile="";
                        intStartByte=intEndByte=intPreviousEndByte=intRemain=intId=intPart=intPartId=intPartSizeRemove=0;
                        dtbltemp.Rows.Clear();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertSplitMaster()
        {
            string qry = "insert into SplitFileMaster(FileName,TotalSize,Create_Date,User_Id)Values(@filename,@totalsize,@createdate,@userid)";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = frmLogin.UserId;
            cmd.Parameters.Add("@filename",SqlDbType.VarChar).Value=strpath.Substring(strpath.LastIndexOf(@"\") + 1, (strpath.LastIndexOf(".") - strpath.LastIndexOf(@"\") - 1));
            cmd.Parameters.Add("@totalsize",SqlDbType.Int).Value=txtTotalSize.Text;
            cmd.Parameters.Add("@createdate",SqlDbType.DateTime).Value=Convert.ToDateTime(System.DateTime.Now).ToString("dd-MMM-yyyy");
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
                cmd.Parameters.Add("@splitfile_id", SqlDbType.Int).Value =intMaxId;
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

        private void txtPartSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57 || Convert.ToInt32(e.KeyChar) == 8))
            {
                e.Handled = true;
                erpWizardSplit.SetError(txtPartSize, "Enter Only Digits");
                MessageBox.Show(erpWizardSplit.GetError(txtPartSize),"FFSJ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void txtPartSize_TextChanged(object sender, EventArgs e)
        {
            erpWizardSplit.Clear();
        }

        }
}
