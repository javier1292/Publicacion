using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD
{
    public class Class1
    {


         public bool acceso;
         public string foto = User.foto;


        private BDconexion Conexion = new BDconexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void Insertar(string Nombre, String Apellido, String correo, String foto, String Usuario, string Contra, string Ccontra)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into Registro values ('" + Nombre + "','" + correo + "','" + foto + "','" + Apellido + "','" + Usuario + "','" + Contra + "','" + Ccontra + "')";
            comando.ExecuteNonQuery();

        }

       

        public void InsertarP(string titulo, string contenido, string fecha)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "insert into publicacion values (" + User.user + " , '" + titulo + "' , '" + contenido + "' , '" + fecha + "')";

            comando.ExecuteNonQuery();



        }

        public DataTable MostrarP()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "select * from publicacion where IDU=" + User.user;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;


        }
       

        public void Eliminar(int ID)
        {




            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "Eliminar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", ID);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(int ID, string titulo, string contenido)
        {

            SqlCommand comando = new SqlCommand();


            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "Editar ";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", ID);
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@contenido", contenido);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();




        }


        public bool Login(string Usuario, string Contra)
        {

            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "SELECT usuario, contraseña FROM Registro where usuario='" + Usuario + "' And contraseña='" + Contra + "'";
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                acceso = true;
                
            }
            else
            {
                acceso = false;
            }

            Conexion.CerrarConexion();
            comando.Connection = Conexion.AbrirConexion();

            string query = "SELECT Id FROM Registro where usuario='" + Usuario + "' And contraseña='" + Contra + "'";
            comando.CommandText = query;

            User.user = Convert.ToInt32(comando.ExecuteScalar());

            Conexion.CerrarConexion();
            if (acceso==true) {
                comando.Connection = Conexion.AbrirConexion();

                string query1 = "SELECT foto FROM Registro where usuario='" + Usuario + "' And contraseña='" + Contra + "'";
                comando.CommandText = query1;

                User.foto = comando.ExecuteScalar().ToString();

                Conexion.CerrarConexion();
            }
            return acceso;

            





       
        
        
        
     
        
        
        
        }
    }


}
