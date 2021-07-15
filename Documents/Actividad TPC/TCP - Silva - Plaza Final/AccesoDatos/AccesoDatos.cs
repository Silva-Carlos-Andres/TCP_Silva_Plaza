using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
/// <summary>
/// comentario de pruebaaaa para un push
///
/// </summary>


namespace Business
{
    class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public AccesoDatos()
        {
            conexion = new SqlConnection("data source=.\\SQLEXPRESS; initial catalog=SILVA_PLAZA_DB; integrated security=sspi");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            conexion.Open();
            lector = comando.ExecuteReader();
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        internal void ejectutarAccion()
        {
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
        }
    }
}
