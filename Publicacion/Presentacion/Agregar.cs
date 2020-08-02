using BDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Agregar : Form
    {
        Class1 obj = new Class1();
        public Agregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = System.DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            string titulo = textBox2.Text;
            string contenido = textBox1.Text;
            obj.InsertarP(titulo,contenido,fecha);
            MessageBox.Show("Se agrego correctamente  ");

            Publicaciones ss = new Publicaciones();
            ss.Show();
            this.Hide();


        }
    }
}
