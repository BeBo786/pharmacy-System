using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            string role = comUserRole.Text;
            String name = txtName.Text;
            String dob = txtDOB.Text;
            Int64 mobile = Int64.Parse(txtPhoneNo.Text);
            String email = txtEmail.Text;
            String username = txtusername.Text;
            String pass = txtPass.Text;

            try
            {
                query = "insert into users (userRole,name,dob,mobile,email,username,pass) values ('"+role+"','"+name+"','"+dob+"',"+mobile+",'"+email+"','"+username+"','"+pass+"')";
                fn.SetData(query,"Sige Up Successful. ");
            }catch(Exception)
            {
                MessageBox.Show("Username Already Exist.","Erorr",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                
        }
    }
}
