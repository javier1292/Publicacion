using BDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Editar : Form
    {
        Publicaciones pu = new Publicaciones();
        Class1 obj = new Class1();

        public Editar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Editar_Load(object sender, EventArgs e)
        {
            textBox1.Text = model.titulo;
            textBox2.Text = model.contenido;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            obj.Editar(model.ID, textBox1.Text , textBox2.Text);


            MessageBox.Show("Hecho");


            Publicaciones ss = new Publicaciones();
            ss.Show();
            this.Hide();
        }
    }
}
