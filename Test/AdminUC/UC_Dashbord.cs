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
    public partial class UC_Dashbord : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_Dashbord()
        {
            InitializeComponent();
        }
        private void setlabel(DataSet ds,Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();

            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void UC_Dashbord_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole='Admin'";
            ds = fn.GetData(query);
            setlabel(ds, adminlb);
            query = "select count(userRole) from users where userRole='Pharmacist'";
            ds = fn.GetData(query);
            setlabel(ds,pharmalb);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSync_Click(object sender, EventArgs e)
        {
            UC_Dashbord_Load(this, null);
        }
    }
}
