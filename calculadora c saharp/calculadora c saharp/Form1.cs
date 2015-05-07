using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadora_c_saharp
{
    public partial class Form1 : Form
    {
        double dato1;
        double dato2;
        double result;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            operador = " +";
            dato1 = double.Parse(textBox1.Text);
            textBox1.Clear();

        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            operador = " -";
            dato1 = double.Parse(textBox1.Text);
            textBox1.Clear();


        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operador = " *";
            dato1 = double.Parse(textBox1.Text);
            textBox1.Clear();

        }

        private void btndvd_Click(object sender, EventArgs e)
        {
            operador = " /";
            dato1 = double.Parse(textBox1.Text);
            textBox1.Clear();

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            dato2 = double.Parse(textBox1.Text);
            switch (operador)
            {
                case " +":
                    result = dato1 + dato2;
                    textBox1.Text = result.ToString();
                    break;

                case " -":
                    result = dato1 - dato2;
                    textBox1.Text = result.ToString();
                    break;

                case " *":
                    result = dato1 * dato2;
                    textBox1.Text = result.ToString();
                    break;

                case " /":
                    result = dato1 / dato2;
                    textBox1.Text = result.ToString();
                    break;

            }
        }

        private void BTNLIMPIAR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            operador = " raiz";
            dato1 = double.Parse(textBox1.Text);
            result = dato1;
            textBox1.Text = Math.Sqrt(dato1).ToString();

        }

        

        }
    }


       

                    

       