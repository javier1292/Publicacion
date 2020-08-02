using BDD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo
{
   public  class Clase
    {
        public bool acceso;
        public string foto;
        public int ID;

        private Class1 objetocd = new Class1();

       

        private BDconexion Conexion = new BDconexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void Insertar(string Nombre, String Apellido, String correo, String foto, String Usuario, string Contra, string Ccontra)
        {
            objetocd.Insertar(Nombre,correo,foto, Apellido, Usuario, Contra, Ccontra);


        }

        public void InsertarP(string titulo, string contenido, string fecha)
        {
            objetocd.InsertarP(titulo, contenido, fecha);


        }

        public DataTable MostrarP()
        {

            DataTable tabla = new DataTable();
            tabla = objetocd.MostrarP();
            return tabla;
        }


        public void Eliminiar(String ID)
        {

            objetocd.Eliminar(Convert.ToInt32(ID));

        }

        public void Editar(int ID, string titulo,string contenido)
        {

            objetocd.Editar(ID, titulo,contenido);

        }

        public void Login(string Usuario, string Contra)
        {

            objetocd.Login(Usuario, Contra);
            acceso = objetocd.acceso;
            foto = objetocd.foto;

        }
    }
}
