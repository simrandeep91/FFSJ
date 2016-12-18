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
    public partial class frmManageUser : Form
    {
        string flag = "";
        SqlConnection con = new SqlConnection("Server=SHARAD-PC;uid=sa;pwd=student;database=FFSJ");
        SqlDataAdapter dad;
        SqlCommand cmd;
        string Qry;
        DataTable dtbl = new DataTable();
        int Index = 0, UserId = 0;
        public frmManageUser()
        {
            InitializeComponent();
        }

        private void frmManageUser_Load(object sender, EventArgs e)
        {
            getAdminProfile();
            RefreshControls();
            RefreshButtons();
        }
        private void getAdminProfile()
        {
            dtbl.Rows.Clear();
            Qry = "Select UserMaster.User_Name,UserMaster.Password,UserDetail.User_Id,UserDetail.First_Name,UserDetail.Last_Name,UserDetail.DOB,UserDetail.Address,UserDetail.City,UserDetail.State,UserDetail.Zip_Code,UserDetail.Country,UserDetail.Phone,UserDetail.Mobile,UserDetail.Email_Id from UserDetail inner join UserMaster on UserDetail.User_ID=UserMaster.User_ID";
            dad = new SqlDataAdapter(Qry, con);
            dad.Fill(dtbl);
        }
        private void RefreshControls()
        {
            if (dtbl.Rows.Count > 0)
            {
                txtUserNameMU.Text = dtbl.Rows[Index]["User_Name"].ToString();
                txtPasswordMU.Text = dtbl.Rows[Index]["Password"].ToString();
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
            if (dtbl.Rows.Count == 0 || dtbl.Rows.Count == 1)
            {
                btnFirst.Enabled = false;
                btnLast.Enabled = false;
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
            }
            else if (Index == 0)
            {
                btnFirst.Enabled = false;
                btnLast.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = false;
            }
            else if (Index == dtbl.Rows.Count - 1)
            {
                btnFirst.Enabled = true;
                btnLast.Enabled = false;
                btnNext.Enabled = false;
                btnPrevious.Enabled = true;

            }
            else
            {
                btnFirst.Enabled = true;
                btnLast.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            Index = dtbl.Rows.Count - 1;
            getAdminProfile();
            RefreshButtons();
            RefreshControls();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Index += 1;
            getAdminProfile();
            RefreshButtons();
            RefreshControls();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Index -= 1;
            getAdminProfile();
            RefreshButtons();
            RefreshControls();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Index = 0;
            getAdminProfile();
            RefreshButtons();
            RefreshControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            UserId = 0;
            txtUserNameMU.Clear();
            txtPasswordMU.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtEmailID.Clear();
            txtMobile.Clear();
            txtPhone.Clear();
            txtState.Clear();
            txtZipCode.Clear();
            btnFirst.Enabled = false;
            btnLast.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnSaveAndAddNew.Enabled = false;
            btnAddNew.Enabled = false;
            btnSave.Enabled = true;
            flag="add";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserNameMU.Text.Trim() == "")
                {
                    erpManageUser.SetError(txtUserNameMU, "enter the username");
                    MessageBox.Show(erpManageUser.GetError(txtUserNameMU), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserNameMU.Focus();
                }
                else if (txtPasswordMU.Text.Trim() == "")
                {
                    erpManageUser.SetError(txtPasswordMU, "enter the password");
                    MessageBox.Show(erpManageUser.GetError(txtPasswordMU), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPasswordMU.Focus();
                }
                else if (txtFirstName.Text.Trim() == "")
                {
                    erpManageUser.SetError(txtFirstName, "enter the firstname");
                    MessageBox.Show(erpManageUser.GetError(txtFirstName), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();
                }
                else if (txtLastName.Text.Trim() == "")
                {
                    erpManageUser.SetError(txtLastName, "enter the lastname");
                    MessageBox.Show(erpManageUser.GetError(txtLastName), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLastName.Focus();
                }
                else if (txtAddress.Text.Trim() == "")
                {
                    erpManageUser.SetError(txtAddress, "enter the address");
                    MessageBox.Show(erpManageUser.GetError(txtAddress), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                }
                else if (txtCountry.Text.Trim() == "")
                {
                    erpManageUser.SetError(txtCountry, "enter the country");
                    MessageBox.Show(erpManageUser.GetError(txtCountry), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCountry.Focus();
                }
                else if (txtState.Text.Trim() == "")
                {
                    erpManageUser.SetError(txtState, "enter the state");
                    MessageBox.Show(erpManageUser.GetError(txtState), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtState.Focus();
                }
                else if (txtCity.Text.Trim() == "")
                {
                    erpManageUser.SetError(txtCity, "enter the city");
                    MessageBox.Show(erpManageUser.GetError(txtCity), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCity.Focus();
                }
                else if (txtZipCode.Text.Trim() == "")
                {
                    erpManageUser.SetError(txtZipCode, "enter the zipcode");
                    MessageBox.Show(erpManageUser.GetError(txtZipCode), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();
                }
                else if (txtPhone.Text.Trim() == "")
                {
                    erpManageUser.SetError(txtPhone, "enter the phone");
                    MessageBox.Show(erpManageUser.GetError(txtPhone), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                }
                else if (txtMobile.Text.Trim() == "")
                {
                    erpManageUser.SetError(txtMobile, "enter the mobile");
                    MessageBox.Show(erpManageUser.GetError(txtMobile), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMobile.Focus();
                }
                else if (txtEmailID.Text.Trim() == "")
                {
                    erpManageUser.SetError(txtEmailID, "enter the email-id");
                    MessageBox.Show(erpManageUser.GetError(txtEmailID), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailID.Focus();
                }
                else
                {
                    if (flag == "add")
                    {
                        Qry = "Select * from UserMaster where User_Name=@user";
                        SqlDataAdapter dad = new SqlDataAdapter(Qry, con);
                        dad.SelectCommand.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUserNameMU.Text;
                        DataTable dtbl = new DataTable();
                        dad.Fill(dtbl);
                        if (dtbl.Rows.Count > 0)
                        {
                            erpManageUser.SetError(txtUserNameMU, "username already exsists");
                            MessageBox.Show(erpManageUser.GetError(txtUserNameMU), "FFSJ Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUserNameMU.Focus();
                        }
                    }
                    else
                    {
                        if (UserId == 0)
                        {
                            Qry = "Insert into UserMaster(User_Name,Password,User_Type,Status)Values(@username,@password,'User',true);declare @id int select @id=@@Identity;Insert into UserDetail(User_Id,First_Name,Last_Name,Address,DOB,Country,State,City,Zip_Code,Phone,Mobile,Email_ID)Values(@id,@firstname,@lastname,@address,@dob,@country,@state,@city,@zipcode,@phone,@mobile,@emailid)";
                        }
                        else
                        {
                            Qry = "Update UserMaster set User_Name=@username,Password=@password where User_Id=@user_id;Update UserDetail set First_Name=@firstname,Last_Name=@lastname,Address=@address,DOB=@dob,Country=@country,State=@state,City=@city,Zip_Code=@zipcode,Phone=@phone,Mobile=@mobile,Email_ID=@emailid where User_ID=@user_id";
                        }

                        cmd = new SqlCommand(Qry, con);
                        cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = UserId;
                        cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = txtUserNameMU.Text;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = txtPasswordMU.Text;
                        cmd.Parameters.Add("@firstname", SqlDbType.VarChar, 50).Value = txtFirstName.Text;
                        cmd.Parameters.Add("@lastname", SqlDbType.VarChar, 50).Value = txtLastName.Text;
                        cmd.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = txtAddress.Text;
                        cmd.Parameters.Add("@country", SqlDbType.VarChar, 50).Value = txtCountry.Text;
                        cmd.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = txtCity.Text;
                        cmd.Parameters.Add("@state", SqlDbType.VarChar, 50).Value = txtState.Text;
                        cmd.Parameters.Add("@zipcode", SqlDbType.VarChar, 20).Value = txtZipCode.Text;
                        cmd.Parameters.Add("@phone", SqlDbType.VarChar, 20).Value = txtPhone.Text;
                        cmd.Parameters.Add("@mobile", SqlDbType.VarChar, 20).Value = txtMobile.Text;
                        cmd.Parameters.Add("@emailid", SqlDbType.VarChar, 50).Value = txtEmailID.Text;
                        cmd.Parameters.Add("@dob", SqlDbType.DateTime, 8).Value = dtpDateOfBirth.Value;
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Updated Successfully", "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshButtons();
                        btnAddNew.Enabled = true;
                        btnSave.Enabled = false;
                        btnSaveAndAddNew.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveAndAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserId == 0)
                {
                    Qry = "Insert into UserMaster(User_Name,Password)Values(@username,@password);declare @id int select @id=@@Identity;Insert into UserDetail(User_Id,First_Name,Last_Name,Address,DOB,Country,State,City,Zip_Code,Phone,Mobile,Email_ID)Values(@id,@firstname,@lastname,@address,@dob,@country,@state,@city,@zipcode,@phone,@mobile,@emailid)";
                }
                else
                {
                    Qry = "Update UserMaster set User_Name=@username,Password=@password where User_Id=@user_id;Update UserDetail set First_Name=@firstname,Last_Name=@lastname,Address=@address,DOB=@dob,Country=@country,State=@state,City=@city,Zip_Code=@zipcode,Phone=@phone,Mobile=@mobile,Email_ID=@emailid where User_ID=@user_id";
                }
                cmd = new SqlCommand(Qry, con);
                cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = UserId;
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = txtUserNameMU.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = txtPasswordMU.Text;
                cmd.Parameters.Add("@firstname", SqlDbType.VarChar, 50).Value = txtFirstName.Text;
                cmd.Parameters.Add("@lastname", SqlDbType.VarChar, 50).Value = txtLastName.Text;
                cmd.Parameters.Add("@address", SqlDbType.VarChar, 100).Value = txtAddress.Text;
                cmd.Parameters.Add("@country", SqlDbType.VarChar, 50).Value = txtCountry.Text;
                cmd.Parameters.Add("@city", SqlDbType.VarChar, 50).Value = txtCity.Text;
                cmd.Parameters.Add("@state", SqlDbType.VarChar, 50).Value = txtState.Text;
                cmd.Parameters.Add("@zipcode", SqlDbType.VarChar, 20).Value = txtZipCode.Text;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar, 20).Value = txtPhone.Text;
                cmd.Parameters.Add("@mobile", SqlDbType.VarChar, 20).Value = txtMobile.Text;
                cmd.Parameters.Add("@emailid", SqlDbType.VarChar, 50).Value = txtEmailID.Text;
                cmd.Parameters.Add("@dob", SqlDbType.DateTime, 8).Value = dtpDateOfBirth.Value;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated Successfully", "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserId = 0;
                txtUserNameMU.Clear();
                txtPasswordMU.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtAddress.Clear();
                txtCity.Clear();
                txtCountry.Clear();
                txtEmailID.Clear();
                txtMobile.Clear();
                txtPhone.Clear();
                txtState.Clear();
                txtZipCode.Clear();
                btnFirst.Enabled = false;
                btnLast.Enabled = false;
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
                btnAddNew.Enabled = false;
                btnSave.Enabled = true;
                btnSaveAndAddNew.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FFSJ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUserNameMU_TextChanged(object sender, EventArgs e)
        {
            erpManageUser.Clear();
        }

        private void txtPasswordMU_TextChanged(object sender, EventArgs e)
        {
            erpManageUser.Clear();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            erpManageUser.Clear();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            erpManageUser.Clear();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            erpManageUser.Clear();
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            erpManageUser.Clear();
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            erpManageUser.Clear();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            erpManageUser.Clear();
        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {
            erpManageUser.Clear();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            erpManageUser.Clear();
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            erpManageUser.Clear();
        }

        private void txtEmailID_TextChanged(object sender, EventArgs e)
        {
            erpManageUser.Clear();
        }
    }
}
