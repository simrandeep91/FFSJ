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
using System.Collections;

namespace FFSJ
{
    public partial class frmMergeFiles : Form
    {
        SqlConnection con = new SqlConnection("Server=SHARAD-PC;uid=sa;pwd=student;database=FFSJ");
        SqlCommand cmd;
        string strQry = "";
        string strApplicationPath = "";
        string strFolderPath = "";
        string strDirectory = "";
        long lngTotalSize;
        static int intstartbyte = 0;
        static int intendbyte = 0;
        static int intMaxId;
        DataTable dtblTemp;
        public frmMergeFiles()
        {
            InitializeComponent();
            this.Size = new Size(700, 150);
            pnlFile.Visible = false;
        }

        private void frmMergeFiles_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //folderMergeFiles.RootFolder = System.Environment.SpecialFolder.MyComputer;
            

            string strpath = Application.StartupPath;
            
            strpath = strpath.Substring(0, strpath.LastIndexOf("bin"));
            
            strpath += "SplittedFiles";

            folderMergeFiles.SelectedPath = strpath;
            
            folderMergeFiles.ShowNewFolderButton = false;
            if (folderMergeFiles.ShowDialog() == DialogResult.OK)
            {
                txtSelectSourceFolder.Text = folderMergeFiles.SelectedPath;
            }
            erpjoin.Clear();
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSelectSourceFolder.Text == "")
                {
                    erpjoin.SetError(txtSelectSourceFolder, "Please Select Folder To Merge");
                    MessageBox.Show(erpjoin.GetError(txtSelectSourceFolder), "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBrowse.Focus();
                }
                else
                {
                    strApplicationPath = Application.StartupPath;
                    strApplicationPath = strApplicationPath.Substring(0, strApplicationPath.LastIndexOf("bin"));
                    strApplicationPath += "SplittedFiles";
                    strFolderPath = txtSelectSourceFolder.Text;
                    strDirectory = Path.GetFileName(txtSelectSourceFolder.Text);
                    strFolderPath = strFolderPath.Substring(0, strFolderPath.LastIndexOf(@"\"));
                    if (strFolderPath == strApplicationPath)
                    {
                        Boolean boolResult = CheckFolderUnderInfo();
                        if (boolResult == true)
                        {
                            this.Size = new Size(729, 485);
                            GenerateTemporaryTable();
                            GetFileInfo();
                            //this.Size = new Size(700,150);
                            pnlFile.Visible = true;
                            dgvFile.DataSource = dtblTemp;
                        }
                        else
                        {
                            MessageBox.Show("Files Not Valid\n" + "Corrospondong to" + strDirectory + "Directory,\nPlease Contact Administrator", "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.Size = new Size(700,150);
                            pnlFile.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Files Not Valid\n" + "Corrospondong to" + strDirectory + "Directory,\nPlease Contact Administrator", "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Size = new Size(700,150);
                        pnlFile.Visible = false;
                        txtSelectSourceFolder.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private Boolean CheckFolderUnderInfo()
        {
            try
            {
                int intCheck = 0;
                string[] strSubDirectory = Directory.GetDirectories(txtSelectSourceFolder.Text);
                if (strSubDirectory.Length != 0)
                {
                    return false;
                }
                else
                {
                    string[] strFilesUnder = Directory.GetFiles(txtSelectSourceFolder.Text);
                    foreach (string strfname in strFilesUnder)
                    {
                        string strFileName = Path.GetFileName(strfname);
                        strFileName = strFileName.Substring(0, strFileName.IndexOf("."));
                        string strExtension = Path.GetExtension(strfname);
                        if (!(strFileName == strDirectory && strExtension == ".tmp"))
                        {
                            intCheck = 1;
                            break;
                        }
                    }
                }
                if (intCheck == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }
        private void GenerateTemporaryTable()
        {
            try
            {
                dtblTemp = new DataTable();
                dtblTemp.Columns.Add("FileName", typeof(string));
                dtblTemp.Columns.Add("PartSize", typeof(string));
                dtblTemp.Columns.Add("CreateDate", typeof(string));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void GetFileInfo()
        {
             try 
           {
               lblCreateDate.Text = "" + Convert.ToDateTime(Directory.GetCreationTime(txtSelectSourceFolder.Text));
               string[] files = Directory.GetFiles(txtSelectSourceFolder.Text, "*.tmp");
               foreach (string fname in files)
               {
                   string strFileName = Path.GetFileName(fname);
                   strFileName = strFileName.Substring(0, strFileName.IndexOf("."));
                   if (strFileName == strDirectory)
                   {
                       FileInfo f1 = new FileInfo(fname);
                       long lnglength = f1.Length;
                       lnglength = lnglength + 1;
                       lngTotalSize = lngTotalSize + lnglength;
                       string strLenBytes = "" + lnglength + " Bytes";
                       dtblTemp.Rows.Add(Path.GetFileName(fname), strLenBytes, File.GetCreationTime(fname));
                   }
               }
               lblFileUnder.Text = "Files Under " + strDirectory + " Folder";
               lblTotalSize.Text = "" + lngTotalSize;
               dgvFile.DataSource = dtblTemp;
            	}
	        catch (Exception ex)
	        {

                MessageBox.Show(ex.Message.ToString());
	        }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (dtblTemp != null)
            {
                dtblTemp.Rows.Clear();
                dgvFile.DataSource = dtblTemp;
            }
            txtSelectDestinationFolder.Text = "";
            txtSelectSourceFolder.Text = "";
            lblFileUnder.Text = "";
            lblCreateDate.Text = "";
            lblTotalSize.Text = "";
            pnlFile.Visible = false;
            this.Size = new Size(700,150);
        }

        private void btnStartJoining_Click(object sender, EventArgs e)
        {
            if (txtSelectDestinationFolder.Text.Trim() == "")
            {
                erpjoin.SetError(txtSelectDestinationFolder, "Please Select Destination Folder");
                MessageBox.Show(erpjoin.GetError(txtSelectDestinationFolder), "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBrowse1.Focus();
            }
            else
            {
                Merge();
            }
        }
        private void Merge()
        {
            try
            {
                string outputPath = txtSelectDestinationFolder.Text;
                if (Directory.GetFiles(txtSelectSourceFolder.Text, "*.tmp").Length != 0)
                {
                    string[] tmpFiles = Directory.GetFiles(txtSelectSourceFolder.Text, "*.tmp");
                    SortedList strList = new SortedList();
                    foreach (string tempfile in tmpFiles)
                    {
                        string strPart = tempfile.Substring(tempfile.IndexOf("part"), tempfile.Length - tempfile.IndexOf("part"));
                        strPart = strPart.Substring(strPart.IndexOf("part") + 4, strPart.IndexOf("."));
                        string strKey = strPart.Substring(0, strPart.LastIndexOf("."));
                        strList.Add(strKey, tempfile);
                    }
                    FileStream outputFile = null;
                    string prevFileName = "";
                    for (int intcount = 1; intcount <= strList.Count; intcount++)
                    {
                        string strFileName = Path.GetFileName("" + strList["" + intcount]);
                        strFileName = strFileName.Substring(0, strFileName.IndexOf("."));
                        if (strFileName == strDirectory)
                        {
                            string filename = Path.GetFileNameWithoutExtension("" + strList["" + intcount]);
                            string basefilename = filename.Substring(0, filename.IndexOf(Convert.ToChar(".")));
                            string extension = Path.GetExtension(filename);
                            if (!prevFileName.Equals(basefilename))
                            {
                                if (outputFile != null)
                                {
                                    outputFile.Flush();
                                    outputFile.Close();
                                }
                                outputFile = new FileStream(outputPath+@"\"+basefilename+extension, FileMode.OpenOrCreate, FileAccess.Write);
                            }
                            int bytesread = 0;
                            FileStream inputTempFile = new FileStream("" + strList["" + intcount], FileMode.OpenOrCreate, FileAccess.Read);
                            int intFileSize = (int)inputTempFile.Length;
                            intstartbyte = intendbyte;
                            intendbyte = intendbyte + intFileSize;
                            byte[] Buffer = new byte[intendbyte];
                            while ((bytesread = inputTempFile.Read(Buffer, intstartbyte, intendbyte - intstartbyte)) > 0)
                            {
                                outputFile.Write(Buffer, intstartbyte, bytesread);
                            }
                            inputTempFile.Close();
                            //File.Delete(tempFile);
                            prevFileName = basefilename;
                        }
                    }
                    outputFile.Close();
                    InsertMergeFolder();
                    GetMaxId();
                    MergeFileDetail();
                    MessageBox.Show("Temporary files have been merged successfully");
                    this.Close(); ;
                }
                else
                {
                    MessageBox.Show("No files are present to merge");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"FFSJ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void InsertMergeFolder()
        {
            try
            {
                strQry = "insert into MergeFolderMaster(FolderName,TotalSize,Create_Date,User_Id)Values(@paramfoldername,@paramtotalsize,@paramcreatedate,@paramuserid)";
                cmd = new SqlCommand(strQry, con);
                cmd.Parameters.Add("@paramfoldername", SqlDbType.VarChar, 200).Value = strDirectory;
                cmd.Parameters.Add("@paramtotalsize", SqlDbType.Int).Value = Convert.ToInt32(lblTotalSize.Text);
                cmd.Parameters.Add("@paramcreatedate", SqlDbType.DateTime).Value = Convert.ToDateTime(System.DateTime.Now).ToString("dd-MMM-yyyy");
                cmd.Parameters.Add("@paramuserid", SqlDbType.Int).Value = frmLogin.UserId;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetMaxId()
        {
            try
            {
                strQry = "select max(MergeFolderId)from MergeFolderMaster";
                cmd = new SqlCommand(strQry, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                intMaxId = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"FFSJ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void MergeFileDetail()
        {
            try
            {
                strQry = "insert into MergeFolderDetail(MergeFolderId,FileName,PartSize,Create_Date)Values(@parammergefolderid,@paramfilename,@parampartsize,@paramcreatesize)";
                for (int intcount = 0; intcount < dtblTemp.Rows.Count; intcount++)
                {
                    cmd = new SqlCommand(strQry, con);
                    cmd.Parameters.Add("@parammergefolderid", SqlDbType.Int).Value = intMaxId;
                    cmd.Parameters.Add("@paramfilename", SqlDbType.VarChar).Value = dtblTemp.Rows[intcount]["FileName"].ToString();
                    string strpartsize = dtblTemp.Rows[intcount]["PartSize"].ToString();
                    strpartsize = strpartsize.Substring(0, strpartsize.IndexOf(" "));
                    cmd.Parameters.Add("@parampartsize", SqlDbType.Int).Value = Convert.ToInt32(strpartsize);
                    cmd.Parameters.Add("@paramcreatesize", SqlDbType.DateTime).Value = Convert.ToDateTime(System.DateTime.Now).ToString("dd-MMM-yyyy");
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"FFSJ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtSelectDestinationFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse1_Click_1(object sender, EventArgs e)
        {
            folderMergeFiles.Reset();
            folderMergeFiles.RootFolder = System.Environment.SpecialFolder.MyComputer;
            if (folderMergeFiles.ShowDialog() == DialogResult.OK)
            {
               txtSelectDestinationFolder.Text = folderMergeFiles.SelectedPath;
            }
            erpjoin.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }     
}
