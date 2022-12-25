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
    public partial class Uc_p_Dashbord : UserControl
    {
        function fn = new function();
        String qurey;
        DataSet ds;
        Int64 count;

        public Uc_p_Dashbord()
        {
            InitializeComponent();
        }

        private void Uc_p_Dashbord_Load(object sender, EventArgs e)
        {
            loadChart();
        }
        public void loadChart()
        {

            qurey = "Select count(*) mname from medic where eDate > getdate();";
            ds = fn.GetData(qurey);
            String s = ds.Tables[0].Rows[0][0].ToString();
            count = Int64.Parse(s);
            this.chart1.Series["Valid Medicines"].Points.AddXY("Medicine Validity Chart", count);

            qurey = "Select count(*) mname from medic where eDate < getdate();";
            ds = fn.GetData(qurey);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicine"].Points.AddXY("Medicine Validity Chart", count);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            chart1.Series["Valid Medicines"].Points.Clear();
            chart1.Series["Expired Medicine"].Points.Clear();
            loadChart();

        }
    }
}
