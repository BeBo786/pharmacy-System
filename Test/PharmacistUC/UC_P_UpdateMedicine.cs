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
    public partial class UC_P_UpdateMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtmedID.Text != "")
            {
                query = "select * from medic where mid = '"+txtmedID.Text+"'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtmedName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtmedNum.Text= ds.Tables[0].Rows[0][3].ToString();
                    txtmanDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtExpierdate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAvalquantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtperUnit.Text = ds.Tables[0].Rows[0][7].ToString();


                }
                else
                {
                    MessageBox.Show("No medicine with ID: " + txtmedID.Text + " was found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                ClearAll();

            }
            
        }
        private void ClearAll()
        {
            txtmedID.Clear();
            txtmedName.Clear();
            txtmedNum.Clear();
            txtmanDate.ResetText();
            txtExpierdate.ResetText();
            txtAvalquantity.Clear();
            txtperUnit.Clear();

            if (txtaddQuan.Text != "0")
            {
                txtaddQuan.Text = "0";

            }
            else
            {
                txtaddQuan.Text = "0";
            }
        }
        Int64 TotalQuantaity;
        private void ptnRest_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private Int64 validitor()
        {
            try
            {
                Int64 quantity = Int64.Parse(txtAvalquantity.Text);
                Int64 addQuantity = Int64.Parse(txtaddQuan.Text);
                Int64 priceunit = Int64.Parse(txtperUnit.Text);
                TotalQuantaity = quantity + addQuantity;
                return TotalQuantaity;

            }
            catch(Exception)
            {
                MessageBox.Show("enter only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return TotalQuantaity;
            }
        }


        private void ptnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAvalquantity.Text != "" && txtExpierdate.Text != "" && txtmedID.Text != "" && txtmanDate.Text != "" && txtmedNum.Text != "" && txtperUnit.Text != "")
                {
                    String mname = txtmedName.Text;
                    String mnumber = txtmedNum.Text;
                    String mdate = txtmanDate.Text;
                    String edate = txtExpierdate.Text;
                    Int64 quantity = Int64.Parse(txtAvalquantity.Text);
                    Int64 addQuantity = Int64.Parse(txtaddQuan.Text);
                    Int64 priceunit = Int64.Parse(txtperUnit.Text);
                    TotalQuantaity = quantity + addQuantity;


                    //mid,mname,mnumber,mDate,eDate,quantity,perUnit
                    query = "update medic set mname = '" + mname + "',mnumber='" + mnumber + "',mDate='" + mdate + "',eDate='" + edate + "',quantity=" + TotalQuantaity + ",perUnit=" + priceunit + "where mid='" + txtmedID.Text + "'";
                    fn.SetData(query, "Update sucsesfully");
                }
                else
                {
                    MessageBox.Show("Enter all data", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Enter numbers data", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
