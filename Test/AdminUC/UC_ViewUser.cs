using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        String query;
        String CurrentUser = "";
        
        public UC_ViewUser()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { CurrentUser = value; }

        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds= fn.GetData(query);
            gunaDataGridView3.DataSource = ds.Tables[0];
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '"+txtUserName.Text+"%'";
            DataSet ds = fn.GetData(query);
            gunaDataGridView3.DataSource = ds.Tables[0];
        }

        String UserName;
        private void gunaDataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UserName = gunaDataGridView3.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {


                if (CurrentUser != UserName)
                {
                    query = "delete from users where username='" + UserName + "'";
                    fn.SetData(query, "User Record Deleted.");
                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("you try to delet your profile.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gunaDataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }
    }
}
