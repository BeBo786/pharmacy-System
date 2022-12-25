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
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        String qurey;

        public UC_Profile()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { UsernameLP.Text = value; }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            qurey = "select * from users where username = '" + UsernameLP.Text + "'";
            DataSet ds= fn.GetData(qurey);
            txtuserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text= ds.Tables[0].Rows[0][2].ToString();
            txtDOB.Text= ds.Tables[0].Rows[0][3].ToString();
            txtPhone.Text= ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text= ds.Tables[0].Rows[0][5].ToString();
            txtPass.Text= ds.Tables[0].Rows[0][7].ToString();

        }

        private void ptnReset_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }

        private void ptnUpdate_Click(object sender, EventArgs e)
        {
            String role = txtuserRole.Text;
            String name = txtName.Text;
            String dob = txtDOB.Text;
            String email = txtEmail.Text;
            Int64 mobile = Int64.Parse(txtPhone.Text);
            String username = UsernameLP.Text;
            String pass = txtPass.Text;
            qurey = "update users set userRole ='" + role + "',name='" + name + "',dob='" + dob + "',mobile='" + mobile + "',email='" + email + "',pass='" + pass + "'where username='" + username + "'";
            fn.SetData(qurey, "update was sucssesful");

        }
    }
}
