using BDD;
using Metodo;
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
    public partial class Publicaciones : Form
    {
        private Class1 objetoc = new Class1();
       
        public string ID;
        public string titulo;
        public string contenido;
        public string fecha;


        private void Mostrar()
        {
            Class1 obj = new Class1();
            dataGridView1.DataSource = obj.MostrarP();
        }



        public Publicaciones()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ID = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoc.Eliminar(Convert.ToInt32(ID));

                MessageBox.Show("se elmino la encuesta");
                Mostrar();
            }
            else
            {
                MessageBox.Show("seleccione una encuesta");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inicio ss = new Inicio();
            ss.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregar ss = new Agregar();
            ss.Show();
            this.Hide();



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                ID = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                titulo = dataGridView1.CurrentRow.Cells["titulo"].Value.ToString();
                contenido = dataGridView1.CurrentRow.Cells["contenido"].Value.ToString();
                fecha = dataGridView1.CurrentRow.Cells["fecha"].Value.ToString();

                model.ID = Convert.ToInt32(ID);
                model.titulo = titulo;
                model.contenido = contenido;
                model.fecha = fecha;

                Editar ss = new Editar();
                ss.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("seleccione una encuesta");
            }

        }

        private void Publicaciones_Load(object sender, EventArgs e)
        {


            Mostrar();

            pictureBox1.Image = Image.FromFile(objetoc.foto);
       
            
        }
    }
}
