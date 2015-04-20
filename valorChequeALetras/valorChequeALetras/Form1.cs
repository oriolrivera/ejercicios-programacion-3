using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace valorChequeALetras
{
    public partial class Form1 : Form
    {

        CovierteNumerosALetras convierte = new CovierteNumerosALetras();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
          MessageBox.Show(convierte.convierteAletras(valor.Text));
        }

        private void valor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
