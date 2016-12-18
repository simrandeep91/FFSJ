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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Server=SHARAD-PC;uid=sa;Password=student;Database=FFSJ;");
        String Qry;
        SqlDataAdapter dad;
        DataTable dtbl;
        public static int UserId;
        public static string UserName, UserType;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text.Trim() == "")
                {
                    erpLogin.SetError(txtUserName, "enter the username");
                    MessageBox.Show(erpLogin.GetError(txtUserName), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
                else if (txtPassword.Text.Trim() == "")
                {
                    erpLogin.SetError(txtPassword, "enter the password");
                    MessageBox.Show(erpLogin.GetError(txtPassword), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else
                {
                    Qry = "select UserMaster.User_Id,Usermaster.Password,Usermaster.User_Type,Usermaster.Status,Userdetail.First_Name+' '+Userdetail.Last_Name as 'Name' from Usermaster Inner Join Userdetail on Usermaster.User_Id=Userdetail.User_Id where Usermaster.User_Name=@Name";
                    dad = new SqlDataAdapter(Qry, Con);
                    dad.SelectCommand.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = txtUserName.Text;
                    dtbl = new DataTable();
                    dad.Fill(dtbl);
                    if (dtbl.Rows.Count > 0)
                    {
                        if (txtPassword.Text == dtbl.Rows[0]["Password"].ToString())
                        {
                            if (dtbl.Rows[0]["Status"].ToString().ToLower() == "true")
                            {
                                UserId = Convert.ToInt32(dtbl.Rows[0]["User_Id"]);
                                UserName = dtbl.Rows[0]["Name"].ToString();
                                UserType = dtbl.Rows[0]["User_Type"].ToString();
                                frmMain obj = new frmMain();
                                this.Hide();
                                obj.Show();
                            }
                            else
                            {
                                MessageBox.Show("Your Login ID has expired");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid User Name or Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            erpLogin.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
