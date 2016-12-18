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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            lblUserName.Text = frmLogin.UserName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtOldPassword.Text.Trim() == "")
                {
                    erpChangePassword.SetError(txtOldPassword, "enter the old password");
                    MessageBox.Show(erpChangePassword.GetError(txtOldPassword), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPassword.Focus();
                }
                else if (txtNewPassword.Text.Trim() == "")
                {
                    erpChangePassword.SetError(txtNewPassword, "enter the new password");
                    MessageBox.Show(erpChangePassword.GetError(txtNewPassword), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Focus();
                }
                else if (txtNewPassword.Text != txtRetypePassword.Text)
                {
                    erpChangePassword.SetError(txtRetypePassword, "Password do not match");
                    MessageBox.Show(erpChangePassword.GetError(txtRetypePassword), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection Con = new SqlConnection("Server=SHARAD-PC;uid=sa;Password=student;Database=FFSJ;");
                    string Qry = "Select Password from Usermaster where User_Id=@Id";
                    SqlCommand Cmd = new SqlCommand(Qry, Con);
                    Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = frmLogin.UserId;
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }
                    string Password = Cmd.ExecuteScalar().ToString();
                    Con.Close();
                    if (Password == txtOldPassword.Text)
                    {
                        Qry = "Update Usermaster set Password=@Password where User_Id=@Id";
                        Cmd = new SqlCommand(Qry, Con);
                        Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = frmLogin.UserId;
                        Cmd.Parameters.Add("@Password", SqlDbType.VarChar, 20).Value = txtNewPassword.Text;
                        if (Con.State == ConnectionState.Closed)
                        {
                            Con.Open();
                        }
                        Cmd.ExecuteNonQuery();
                        Con.Close();
                        MessageBox.Show("Password change successfully");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Old Password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gbChangePassword_Enter(object sender, EventArgs e)
        {

        }

    }
}
