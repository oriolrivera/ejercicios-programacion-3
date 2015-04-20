using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rectangulotwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           // int myTextbox;
          //  myTextbox = int.Parse(textBox1.Text);
          //  MessageBox.Show(textBox1.Text);

            
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Blue);
            papel.DrawRectangle(lapiz, 10, 20, 34, 50);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int text1 = int.Parse(textBox1.Text);

            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Blue);
            papel.DrawRectangle(lapiz, 10, 20, text1, 50);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

