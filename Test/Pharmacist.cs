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
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uc_p_Dashbord1.Visible = true;
            uc_p_Dashbord1.BringToFront();

        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uc_p_Dashbord1.Visible = false;
            btnDashboard.PerformClick();
            uC_p_AddMed1.Visible = false;
            uC_P_viewMedicine1.Visible = false;
            uC_P_UpdateMedicine1.Visible = false;
            uC_P_SellMed1.Visible = false;
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            uC_p_AddMed1.Visible = true;
            uC_p_AddMed1.BringToFront();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uC_P_viewMedicine1.Visible = true;
            uC_P_viewMedicine1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_P_UpdateMedicine1.Visible = true;
            uC_P_UpdateMedicine1.BringToFront();
        }

        private void btnSellMed_Click(object sender, EventArgs e)
        {
            uC_P_SellMed1.Visible = true;
            uC_P_SellMed1.BringToFront();
        }

        private void uC_P_SellMed1_Load(object sender, EventArgs e)
        {

        }

        private void usernamelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
