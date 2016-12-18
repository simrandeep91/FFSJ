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
    public partial class frmManageProfile : Form
    {
        public frmManageProfile()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=SHARAD-PC;uid=sa;pwd=student;database=FFSJ");
        SqlDataAdapter dad;
        SqlCommand cmd;
        string Qry;
        DataTable dtbl = new DataTable();
        int Index = 0, UserId = 0;

        private void frmManageProfile_Load(object sender, EventArgs e)
        {
            getUserProfile();
            RefreshControls();
            RefreshButtons();
        }
        private void getUserProfile()
        {
            dtbl.Rows.Clear();
            Qry = "Select * from UserDetail inner join UserMaster on UserDetail.User_Id=UserMaster.User_Id";
            dad = new SqlDataAdapter(Qry,con);
            dad.Fill(dtbl);
        }
        private void RefreshControls()
        {
            if (dtbl.Rows.Count > 0)
            {
                UserId = Convert.ToInt32(dtbl.Rows[Index]["User_Id"]);
                txtFirstName.Text = dtbl.Rows[Index]["First_Name"].ToString();
                txtLastName.Text = dtbl.Rows[Index]["Last_Name"].ToString();
                dtpDateOfBirth.Value = Convert.ToDateTime(dtbl.Rows[Index]["DOB"].ToString());
                txtAddress.Text = dtbl.Rows[Index]["Address"].ToString();
                txtCountry.Text = dtbl.Rows[Index]["Country"].ToString();
                txtState.Text = dtbl.Rows[Index]["State"].ToString();
                txtCity.Text = dtbl.Rows[Index]["City"].ToString();
                txtEmailID.Text = dtbl.Rows[Index]["Email_ID"].ToString();
                txtZipCode.Text = dtbl.Rows[Index]["Zip_code"].ToString();
                txtPhone.Text = dtbl.Rows[Index]["Phone"].ToString();
                txtMobile.Text = dtbl.Rows[Index]["Mobile"].ToString();
            }
        }
        private void RefreshButtons()
        {
            btnCancel.Enabled = true;
            btnReset.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtEmailID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMobile.Clear();
            txtPhone.Clear();
            txtState.Clear();
            txtZipCode.Clear();
            btnSave.Enabled = true;
            btnReset.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text.Trim() == "")
                {
                    erpManageProfile.SetError(txtFirstName, "enter the firstname");
                    MessageBox.Show(erpManageProfile.GetError(txtFirstName), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();
                }
                else if (txtLastName.Text.Trim() == "")
                {
                    erpManageProfile.SetError(txtLastName, "enter the lastname");
                    MessageBox.Show(erpManageProfile.GetError(txtLastName), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLastName.Focus();
                }
                else if (txtAddress.Text.Trim() == "")
                {
                    erpManageProfile.SetError(txtAddress, "enter the address");
                    MessageBox.Show(erpManageProfile.GetError(txtAddress), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                }
                else if (txtCountry.Text.Trim() == "")
                {
                    erpManageProfile.SetError(txtCountry, "enter the country");
                    MessageBox.Show(erpManageProfile.GetError(txtCountry), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCountry.Focus();
                }
                else if (txtState.Text.Trim() == "")
                {
                    erpManageProfile.SetError(txtState, "enter the state");
                    MessageBox.Show(erpManageProfile.GetError(txtState), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtState.Focus();
                }
                else if (txtCity.Text.Trim() == "")
                {
                    erpManageProfile.SetError(txtCity, "enter the city");
                    MessageBox.Show(erpManageProfile.GetError(txtCity), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCity.Focus();
                }
                else if (txtZipCode.Text.Trim() == "")
                {
                    erpManageProfile.SetError(txtZipCode, "enter the zipcode");
                    MessageBox.Show(erpManageProfile.GetError(txtZipCode), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();
                }
                else if (txtPhone.Text.Trim() == "")
                {
                    erpManageProfile.SetError(txtPhone, "enter the phone");
                    MessageBox.Show(erpManageProfile.GetError(txtPhone), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                }
                else if (txtMobile.Text.Trim() == "")
                {
                    erpManageProfile.SetError(txtMobile, "enter the mobile");
                    MessageBox.Show(erpManageProfile.GetError(txtMobile), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMobile.Focus();
                }
                else if (txtEmailID.Text.Trim() == "")
                {
                    erpManageProfile.SetError(txtEmailID, "enter the email-id");
                    MessageBox.Show(erpManageProfile.GetError(txtEmailID), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailID.Focus();
                }
                else
                {
                    Qry = "update UserDetail set First_Name=@FirstName,Last_Name=@LastName,Address=@Address,DOB=@DOB,Country=@Country,State=@State,City=@City,Zip_Code=@ZipCode,Phone=@Phone,Mobile=@Mobile,Email_ID=@EmailID where User_ID=@User_ID;";
                    cmd = new SqlCommand(Qry, con);
                    cmd.Parameters.Add("@User_ID", SqlDbType.Int).Value = UserId;
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = txtFirstName.Text;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = txtLastName.Text;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar, 100).Value = txtAddress.Text;
                    cmd.Parameters.Add("@Country", SqlDbType.VarChar, 50).Value = txtCountry.Text;
                    cmd.Parameters.Add("@City", SqlDbType.VarChar, 50).Value = txtCity.Text;
                    cmd.Parameters.Add("@State", SqlDbType.VarChar, 50).Value = txtState.Text;
                    cmd.Parameters.Add("@ZipCode", SqlDbType.VarChar, 20).Value = txtZipCode.Text;
                    cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 20).Value = txtPhone.Text;
                    cmd.Parameters.Add("@Mobile", SqlDbType.VarChar, 20).Value = txtMobile.Text;
                    cmd.Parameters.Add("@EmailID", SqlDbType.VarChar, 50).Value = txtEmailID.Text;
                    cmd.Parameters.Add("@DOB", SqlDbType.DateTime, 8).Value = dtpDateOfBirth.Value;
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Updated Successfully", "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    btnReset.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gbPersonalInfo_Enter(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            erpManageProfile.Clear();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            erpManageProfile.Clear();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            erpManageProfile.Clear();
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            erpManageProfile.Clear();
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            erpManageProfile.Clear();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            erpManageProfile.Clear();
        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {
            erpManageProfile.Clear();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            erpManageProfile.Clear();
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            erpManageProfile.Clear();
        }

        private void txtEmailID_TextChanged(object sender, EventArgs e)
        {
            erpManageProfile.Clear();
        }
    }
}
