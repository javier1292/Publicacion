using BDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class registro : Form
    {
        string foto;

        public registro()
        {
            InitializeComponent();
        }
        private Class1 objetoc = new Class1();

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string cor = textBox3.Text;
            

            string ape = textBox5.Text;
            string user = textBox4.Text;
            string pass = textBox2.Text;
            string passc = textBox6.Text;

            if (nom != "" || ape != "" || user != "" || pass != "" || passc != "")
            {
                if (pass.Equals(passc))
                {
                    try
                    {

                        objetoc.Insertar(textBox1.Text, textBox5.Text, textBox3.Text, foto, textBox4.Text, textBox2.Text, textBox6.Text);
                        MessageBox.Show("Registro completado ");


                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo registrar " + ex);
                    }

                    Inicio ss = new Inicio();
                    ss.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Aun faltan campos por llenar");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult rs = op.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
                foto = op.FileName;
            }
        }
    }
}  

