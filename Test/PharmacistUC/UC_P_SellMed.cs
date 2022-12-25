using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.PharmacistUC
{
    public partial class UC_P_SellMed : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_P_SellMed()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_P_SellMed_Load(object sender, EventArgs e)
        {
            listBoxMed.Items.Clear();
            query = "select mname from medic where eDate>= getdate() and quantity>'0'";
            ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMed.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void BtnSync_Click(object sender, EventArgs e)
        {
            UC_P_SellMed_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMed.Items.Clear();
            query = "select mname from medic where mname like'" + txtSearch.Text + "%' and eDate >=getdate() and quantity>'0'";
            ds=fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMed.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoUnit.Clear();
            String name = listBoxMed.GetItemText(listBoxMed.SelectedItem);
            txtmedName.Text = name;
            query = "select mid,eDate,perUnit from medic where mname='" + name + "'";
            ds = fn.GetData(query);
            txtmedID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpierdate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPriceper.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtNoUnit_TextChanged(object sender, EventArgs e)
        {
            if (txtNoUnit.Text != "")
            {
                try
                {
                    Int64 unitPrice = Int64.Parse(txtPriceper.Text);
                    Int64 noOfUnit = Int64.Parse(txtNoUnit.Text);
                    Int64 totalAmount = unitPrice * noOfUnit;
                    txtTotalPrice.Text = totalAmount.ToString();
                }
                catch (Exception)
                {

                }
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

       

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (txtmedID.Text != "")
            {
                query = "select quantity from medic where mid ='" + txtmedID.Text + "'";
                ds = fn.GetData(query);
                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                try 
                { 
                    newQuantity = quantity - Int64.Parse(txtNoUnit.Text);
                }
                catch (Exception){
                }

                if (newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtmedID.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtmedName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value =txtExpierdate.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtPriceper.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtNoUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    Totallbl.Text = "EG. " + totalAmount.ToString();
                    query="update medic set quantity='"+newQuantity+"'where mid='"+txtmedID.Text+"'";
                    fn.SetData(query,"Medicine Added.");
                }
                else
                {
                    MessageBox.Show("Medicine is out of Stock.\n only " + quantity + " left", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);          
                }
                ClearAll();
                UC_P_SellMed_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine First ","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

        }
        int valuAmount;
        String valuId;
        protected Int64 noofUnit;

        

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valuAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valuId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noofUnit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {

            }
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valuId != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medic where mid='" + valuId + "'";
                    ds = fn.GetData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noofUnit;
                    query = "update medic set quantity = '" + newQuantity + "'where mid ='" + valuId + "'";
                    fn.SetData(query, "Medicine Rmoved  from  Cart. ");
                    totalAmount = totalAmount - valuAmount;
                    Totallbl.Text = "EG. " + totalAmount.ToString();
                }
                UC_P_SellMed_Load(this, null);
            }
        }

        private void BtnPurches_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new  DGVPrinter();
            print.Title = "Medicine Bill ";
            print.SubTitle=String.Format("Date:-{0}",DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total payment : " + Totallbl.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            Totallbl.Text = "EG. 00";
            guna2DataGridView1.DataSource = 0;

        }
        private void ClearAll()
        {
            txtmedID.Clear();
            txtmedName.Clear();
            txtExpierdate.ResetText();
            txtPriceper.Clear();
            txtNoUnit.Clear();


        }
    }
}
