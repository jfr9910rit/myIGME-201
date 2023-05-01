using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTest3Question2_Reester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.radioButton1.CheckedChanged += new EventHandler(RadioButton1__CheckedChanged);
            this.radioButton2.CheckedChanged += new EventHandler(RadioButton2__CheckedChanged);
            this.radioButton3.CheckedChanged += new EventHandler(RadioButton3__CheckedChanged);
            this.radioButton4.CheckedChanged += new EventHandler(RadioButton4__CheckedChanged);
            this.radioButton5.CheckedChanged += new EventHandler(RadioButton5__CheckedChanged);
            this.radioButton6.CheckedChanged += new EventHandler(RadioButton6__CheckedChanged);
            this.radioButton7.CheckedChanged += new EventHandler(RadioButton7__CheckedChanged);
            this.radioButton8.CheckedChanged += new EventHandler(RadioButton8__CheckedChanged);
            this.radioButton9.CheckedChanged += new EventHandler(RadioButton9__CheckedChanged);
            this.radioButton10.CheckedChanged += new EventHandler(RadioButton10__CheckedChanged);
            this.radioButton11.CheckedChanged += new EventHandler(RadioButton11__CheckedChanged);
            this.radioButton12.CheckedChanged += new EventHandler(RadioButton12__CheckedChanged);
            this.radioButton13.CheckedChanged += new EventHandler(RadioButton13__CheckedChanged);
            this.radioButton14.CheckedChanged += new EventHandler(RadioButton14__CheckedChanged);
            this.radioButton15.CheckedChanged += new EventHandler(RadioButton15__CheckedChanged);
            this.radioButton16.CheckedChanged += new EventHandler(RadioButton16__CheckedChanged);

            this.pictureBox1.MouseEnter += new EventHandler(PictureBox__MouseEnter);
            this.pictureBox1.MouseLeave += new EventHandler(PictureBox__MouseLeave);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton1__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[0];

        }

        private void RadioButton2__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[1];

        }

        private void RadioButton3__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[2];

        }

        private void RadioButton4__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[3];

        }

        private void RadioButton5__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[4];

        }

        private void RadioButton6__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[5];

        }

        private void RadioButton7__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[6];

        }

        private void RadioButton8__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[7];

        }

        private void RadioButton9__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[8];

        }

        private void RadioButton10__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[9];

        }

        private void RadioButton11__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[10];

        }

        private void RadioButton12__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[11];

        }

        private void RadioButton13__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[12];

        }

        private void RadioButton14__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[13];

        }

        private void RadioButton15__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[14];

        }

        private void RadioButton16__CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[15];

        }

        private void PictureBox__MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Height *= 2;
            pictureBox.Width *= 2;
            pictureBox.BringToFront();
        }
        private void PictureBox__MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Height /= 2;
            pictureBox.Width /= 2;
        }
    }
}
