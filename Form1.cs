using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace october22form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //set a color as the background of the picture box.
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }



        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the picture
            pictureBox1.Image = null;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //shows the open file dialog window, if user selects 
            // an image file load that file into the picturebox.
             if (openFileDialog1.ShowDialog() == DialogResult.OK)
              {
                  pictureBox1.Load(openFileDialog1.FileName);
              }
              else
              {

              }
           
        }
       

        private void stretchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stretchCheckBox.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
