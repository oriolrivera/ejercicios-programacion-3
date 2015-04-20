using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace impuestoSobreRentaEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

            double sueldo = double.Parse(pago.Text); 

            MessageBox.Show("Nombre = " + nombre.Text + " Apellido = " + apellido.Text + " Cedula = " + cedula.Text);

            if (sueldo <= 3)
            {
                MessageBox.Show("Su Sueldo = " + Convert.ToDouble(sueldo) + " y esta exento");
            }
            else if (sueldo >= 33327 && sueldo <= 49990)          
            {
                MessageBox.Show("Su Sueldo = " + sueldo + " y tiene que pagar 15% de su sueldo");
                double Apagar = 0.15 * sueldo;
                MessageBox.Show("Monto a pagar = " + string.Format("{0:#,##0.00}", Apagar));
                
            }
            else if (sueldo >= 49991 && sueldo <= 69431)
            {
                MessageBox.Show("Su Sueldo = " + sueldo + " y tiene que pagar 20% de su sueldo");
                double Apagar = 0.20 * sueldo;
                MessageBox.Show("Monto a pagar = " + string.Format("{0:#,##0.00}", Apagar));
            }

            else if (sueldo >= 69432)
            {
                MessageBox.Show("Su Sueldo = " + sueldo + " y tiene que pagar 25% de su sueldo");
                double Apagar = 0.25 * sueldo;
                MessageBox.Show("Monto a pagar = " + string.Format("{0:#,##0.00}", Apagar));
            }
            
           
           
        }
    }
}
