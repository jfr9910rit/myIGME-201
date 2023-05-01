using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTest3Question3_Reester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Size = new Size(500,500);
            this.button1.Click += new EventHandler(Button1__Clicked);
            this.textBox1.TextChanged += new EventHandler(TextBox1__TextChanged);
            this.linkLabel1.Click += new EventHandler(LinkLabel1__Click);

            this.button2.Click += new System.EventHandler(Button2__Click);
            this.button3.Click += new System.EventHandler(Button3__Click);
            this.button4.Click += new System.EventHandler(Button4__Click);
            this.button5.Click += new System.EventHandler(Button5__Click);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Not This";
        }

        private void Button1__Clicked(object sender, EventArgs e)
        {
            this.label1.Text = "Oh you found it now figure out this.";
            this.button1.Visible = false;
            this.textBox1.Visible = true;
        }

        private void TextBox1__TextChanged(object sender, EventArgs e)
        {
            if(this.textBox1.Text == "Kraftfahrzeug-Haftpflichtversicherung")
            {
                this.textBox1.Visible = false;
                this.label1.Text = "How did you guess that? No matter this one will get you";
                this.Size = new Size(8000, 8000);
                
            }
            

        }

        private void LinkLabel1__Click(object sender, EventArgs e)
        {
            this.label1.Text = "alright last one, or is it? Enter the phone number.";
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.button5.Visible = true;
        }

        private void Button2__Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.label2.Text);
            num1 += 1;
            this.label2.Text = num1.ToString();
        }

        private void Button5__Click(object sender, EventArgs e)
        { 
            if (label2.Text == "999" && label3.Text == "999" && label4.Text == "9999")
            {
                Application.Exit();
            }
        }

        private void Button4__Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.label3.Text);
            num1 += 1;
            this.label3.Text = num1.ToString();
        }

        private void Button3__Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.label4.Text);
            num1 += 1;
            this.label4.Text = num1.ToString();
        }
    }
}
