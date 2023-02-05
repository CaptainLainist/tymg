using AsciiConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        //if it's int returns true true
        private bool isNumber(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
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
                Bitmap img = new Bitmap(txtbox_ruta.Text);
                pictureBox1.Image = img;
            }

            

        }

        private void btn_img2text_Click(object sender, EventArgs e)
        {
            AsciiConv ac = new AsciiConv();
            if (isNumber(txt_dark.Text) || ascii_chkbox.Checked) { 


                try {
                   

                    if (isNumber(txtbox_iheight.Text) && isNumber(txtbox_iwidth.Text))
                    {
                        ac.img_x = Int32.Parse(txtbox_iwidth.Text);
                        ac.img_y = Int32.Parse(txtbox_iheight.Text);

                        if (ac.img_x > 0 && ac.img_y > 0 && ac.img_x <= 500 && ac.img_y <= 500)
                        {
                            if (!ascii_chkbox.Checked)
                            {
                                ac.darkness = Int32.Parse(txt_dark.Text);
                                txtbox_output.Text = ac.getTextBraille(txtbox_ruta.Text);

                            }
                            else
                            {
                                txtbox_output.Text = ac.getTextAscii(txtbox_ruta.Text);
                            }
                        } else
                        {
                            MessageBox.Show("Error: select more than 0 and less than 501 dimensions");
                        }

                       
                    } else
                    { 
                        MessageBox.Show("Error: select valid width and height dimensions");
                    }

                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("Error: select a valid image route");
                }
                
               
            } else {
                MessageBox.Show("Error: select a valid level of darkness");
            }
        }

        private void button_ctcb_Click(object sender, EventArgs e)
        {
            if (txtbox_output.Text != String.Empty) {
                System.Windows.Forms.Clipboard.SetText(txtbox_output.Text);

                timer_copied.Enabled = true;
                label_cptcb.Text = "Output copied to clipboard...";
            } else {
                MessageBox.Show("Error: There is no output");
            }
            
        }

        private void timer_copied_Tick(object sender, EventArgs e)
        {
            label_cptcb.Text = " ";{
            
            }
            timer_copied.Enabled = false;
        }
    }
}
