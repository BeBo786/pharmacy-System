using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.AdminUC
{
    public partial class Uc_Adduser : UserControl
    {
        function fn = new function();
        String query;
        public Uc_Adduser()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtName.Clear();
            txtDOB.ResetText();
            txtPhoneNo.Clear();
            txtEmail.Clear();
            txtusername.Clear();
            txtPass.Clear();
            comUserRole.SelectedIndex = -1;
            Phone_Valid.Text = "";
            pass_Valid.Text = "";
            email_Valid.Text = "";
            Name_Valid.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void comUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            Validitor va = new Validitor();
            va.FRIST_name= txtName.Text;
            va.User_email = txtEmail.Text;
            va.User_password = txtPass.Text;
            va.User_phone = txtPhoneNo.Text;

            ValidationContext validationContext = new ValidationContext(va);
            IList<ValidationResult>errors= new List<ValidationResult>();
            if (!Validator.TryValidateObject(va, validationContext, errors, true))
            {
                foreach (var item in errors)
                {
                    switch (item.MemberNames.First())
                    {
                        case "FRIST_name":
                            //MessageBox.Show(item.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Name_Valid.Text = item.ErrorMessage;
                            Name_Valid.ForeColor = Color.Red;
                            break;
                        case "User_email":
                            email_Valid.Text = item.ErrorMessage;
                            email_Valid.ForeColor = Color.Red;
                            break;
                        case "User_password":
                            pass_Valid.Text = item.ErrorMessage;
                            pass_Valid.ForeColor = Color.Red;
                            break;
                        case "User_phone":
                            Phone_Valid.Text = item.ErrorMessage;
                            Phone_Valid.ForeColor = Color.Red;
                            break;

                    }
                }
            }
            else
            {
                String role = comUserRole.Text;
                String name = txtName.Text;
                String dob = txtDOB.Text;
                Int64 mobile = Int64.Parse(txtPhoneNo.Text);
                String email = txtEmail.Text;
                String username = txtusername.Text;
                String pass = txtPass.Text;
                try

                {
                    query = "insert into users (userRole,name,dob,mobile,email,username,pass) values ('" + role + "','" + name + "','" + dob + "'," + mobile + ",'" + email + "','" + username + "','" + pass + "')";
                    fn.SetData(query, "Sige Up Successful. ");

                    Phone_Valid.Text="";
                    pass_Valid.Text = "";
                    email_Valid.Text = "";
                    Name_Valid.Text = "";
                }
                catch (Exception)

                {
                    MessageBox.Show("Username Already Exist.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
