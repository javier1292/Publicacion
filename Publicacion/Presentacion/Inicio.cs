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
    public partial class Inicio : Form
    {
        Class1 obj = new Class1();
        public bool acceso;
        


        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            registro ss = new registro();
            ss.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Usuario = textBox1.Text;
            string Contraseña = textBox2.Text;
            obj.Login(Usuario, Contraseña);

            acceso = obj.acceso;

            if (acceso == true)
            {
                Publicaciones ss = new Publicaciones();
                ss.Show();
                this.Hide();

                acceso = false;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
