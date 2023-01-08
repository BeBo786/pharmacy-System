using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patagames.Ocr;

namespace Test.PharmacistUC
{
    public partial class UC_p_OCR : UserControl
    {
        public UC_p_OCR()
        {
            InitializeComponent();
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            String imageLocation = ""; 
            try
            {
                OpenFileDialog dialog= new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation= dialog.FileName;

                    ImageLoc.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            using(var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                string plainText = objOcr.GetTextFromImage(ImageLoc.ImageLocation);
                Txt_Data.Text = plainText;
            }
        }
    }
}
