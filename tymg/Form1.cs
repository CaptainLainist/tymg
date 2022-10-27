using AsciiConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tymg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_load_Click(object sender, EventArgs e)
        {
            //open file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.RestoreDirectory = true;
            ofd.Title = "Open image";
            ofd.DefaultExt = "png";
            ofd.Filter = "png files (*.png)|*.png|bmp files (*.bmp)|*.bmp|jpeg files(*.jpeg)|(*.jpeg)";
            ofd.FilterIndex = 1;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtbox_ruta.Text = ofd.FileName;
            }

        }

        private void btn_img2text_Click(object sender, EventArgs e)
        {
            AsciiConv ac = new AsciiConv();
            ac.darkness = Int32.Parse(txt_dark.Text);

            Bitmap img = new Bitmap(txtbox_ruta.Text);

            pictureBox1.Image = img;

            txtbox_output.Text = ac.getText(txtbox_ruta.Text);
        }
    }
}
