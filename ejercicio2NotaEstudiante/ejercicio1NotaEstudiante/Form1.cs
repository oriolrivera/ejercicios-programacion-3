using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ejercicio1NotaEstudiante
{
    public partial class Form1 : Form
    {
        //Variables para trabajar con archivos
        StreamWriter oFilesw;
        StreamReader oFilesr;

       

        public Form1()
        {
            InitializeComponent();
        }

        //metodo de lectura
        private void SubOpenFileToRead()
        {
            //close file
            oFilesw.Close();

            //open to read
            oFilesr = new StreamReader("estudiante.txt");

            string line = "";

            while ((line = oFilesr.ReadLine()) != null)
            {
                //validar que no haya nada que ignorar
               
                    lvContent.Items.Add(line);
                
            }
            oFilesr.Close();

        }

        private void SubOpenFileWrie()
        {
            //open fille for write
            oFilesw = new StreamWriter("estudiante.txt");

        }

        //metodo para validar si los valores son numericos
        private bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oFilesw.Close();
            btncal.Enabled = false;
            MessageBox.Show("Archivo generado y datos guardado con exito.");
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            //read file
            SubOpenFileToRead();

            //disable button
            btncal.Enabled = true;
        }

        private void btncal_Click_1(object sender, EventArgs e)
        {
            //si los valores ingresados no son numericos muestro mensaje con errorprovider
            if (!IsNumeric(nota1.Text) || (!IsNumeric(nota2.Text)) || (!IsNumeric(nota3.Text)) || (!IsNumeric(nota4.Text)))
            {

                MessageBox.Show("Debe Ingresar Valores Numericos en las notas");
            }
            else
            {

                MessageBox.Show("Nombre = " + nombre.Text + " Apellido = " + apellido.Text + " Matricula = " + matricula.Text);

                if (nombre.Text == String.Empty)
                {
                    MessageBox.Show("Nombre necesario");
                    return;
                }

                if (apellido.Text == String.Empty)
                {
                    MessageBox.Show("Apellido necesario");
                    return;
                }

                if (matricula.Text == String.Empty)
                {
                    MessageBox.Show("Matricula necesaria");
                    return;
                }

                if (nota1.Text == String.Empty)
                {
                    MessageBox.Show("Nota 1 necesaria");
                    return;
                }

                if (nota2.Text == String.Empty)
                {
                    MessageBox.Show("Nota 2 necesaria");
                    return;
                }

                if (nota3.Text == String.Empty)
                {
                    MessageBox.Show("Nota 3 necesaria");
                    return;
                }

                if (nota4.Text == String.Empty)
                {
                    MessageBox.Show("Nota 4 necesaria");
                    return;
                }

                int vnota1 = int.Parse(nota1.Text);
                int vnota2 = int.Parse(nota2.Text);
                int vnota3 = int.Parse(nota3.Text);
                int vnota4 = int.Parse(nota4.Text);
                int vnota5;
                int result;

                //int vnota5 = int.Parse(vnota5.Text);

                if (nota5.Text == String.Empty)
                {
                    vnota5 = 0;
                }
                else if (!(IsNumeric(nota5.Text)))
                {
                    MessageBox.Show("Campo nota 5 debe ser numerico");
                    return;

                }
                else
                {
                    vnota5 = int.Parse(nota5.Text);
                }

                result = vnota1 + vnota2 + vnota3 + vnota4 + vnota5;



                MessageBox.Show("Resultado = " + result);

                //open the file for write
                SubOpenFileWrie();
                oFilesw.WriteLine("Nombre = " + nombre.Text + " Apellido = " + apellido.Text + " Matricula = " + matricula.Text);
                oFilesw.WriteLine("Nota ecuenttro 1 = " + vnota1);
                oFilesw.WriteLine("Nota ecuenttro 2 = " + vnota2);
                oFilesw.WriteLine("Nota ecuenttro 3 = " + vnota3);
                oFilesw.WriteLine("Nota ecuenttro 4 = " + vnota4);
                oFilesw.WriteLine("Nota ecuenttro 5 = " + vnota5);
                oFilesw.WriteLine("Resultado Nota Final = " + result);

                if (result >= 90 && result <= 100)
                {
                    oFilesw.WriteLine("A");
                }
                else if (result >= 80 && result <= 89)
                {
                    oFilesw.WriteLine("B");
                }
                else if (result >= 70 && result <= 79)
                {
                    oFilesw.WriteLine("C");
                }
                else if (result >= 54 && result <= 73 && vnota5 == 0)
                {
                    oFilesw.WriteLine("I");
                }
                else if (result < 70)
                {
                    oFilesw.WriteLine("F");
                }

                btncal.Enabled = false;
                btnleer.Enabled = true;
            }//end validate numeric
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void salir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        

    }
}
