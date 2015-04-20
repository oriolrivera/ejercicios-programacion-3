using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace estudianteAgregarMateria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get input form
            string name = nombre.Text;
            string pallido = apellido.Text;
            string matricula = matric.Text;
            string materia = mater.Text;
            //add item listView
            listView1.Items.Add("Nombre | " + name, 6);
            listView1.Items.Add("Apellido | " + pallido, 6);
            listView1.Items.Add("Matricula | " + matricula, 10);
            listView1.Items.Add("Materia | " + materia, 6);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void retirar_Click(object sender, EventArgs e)
        {
            // Removes the first item in the list.
            listView1.Items.RemoveAt(0);
            // Clears all the items.
            listView1.Items.Clear();
        }
    }
}
