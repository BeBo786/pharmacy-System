using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if(txtUsername.Text=="admin"&& txtPassword.Text == "admin")
                {
                    Admin am = new Admin();
                    am.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("UserName OR Password Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "select * from users where username ='" + txtUsername.Text + "' and pass='" + txtPassword.Text + "'";
                ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count!=0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Admin")
                    {
                        Admin am = new Admin(txtUsername.Text);
                        am.Show();
                        this.Hide();
                    }else if(role =="Pharmacist")
                    {
                        Pharmacist Pharma = new Pharmacist();
                        Pharma.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("UserName OR Password Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
