using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.PharmacistUC
{
    public partial class UC_p_AddMed : UserControl
    {
        function fn = new function();
        String qurey;
        public UC_p_AddMed()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtmedID.Text != "" && txtmedName.Text != "" && txtmedNum.Text != "" && txtquantity.Text != "" && txtperUnit.Text != "")
            {
                String mid = txtmedID.Text;
                String mname = txtmedName.Text;
                String mnumber = txtmedNum.Text;
                String mdate = txtmanDate.Text;
                String edate = txtExpierdate.Text;
                Int64 quantity = Int64.Parse(txtquantity.Text);
                Int64 perunit = Int64.Parse(txtperUnit.Text);

                qurey = "insert into medic(mid,mname,mnumber,mDate,eDate,quantity,perUnit) values ('" + mid + "','" + mname + "','" + mnumber + "','" + mdate + "','" + edate + "'," + quantity + "," + perunit + ")";

                fn.SetData(qurey, "Medicine has been Added Sucsessfuly");
            }
            else
            {
                MessageBox.Show("Enter all data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtmedID.Clear();
            txtmedName.Clear();
            txtquantity.Clear();
            txtmedNum.Clear();
            txtperUnit.Clear();
            txtmanDate.ResetText();
            txtExpierdate.ResetText();
        }

        private void UC_p_AddMed_Load(object sender, EventArgs e)
        {

        }
    }
}
