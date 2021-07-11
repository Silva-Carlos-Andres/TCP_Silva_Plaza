using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class TipoBusiness
    {
        public List<Tipo> Listar()
        {
            List<Tipo> lista = new List<Tipo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select *from Tipo");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Tipo aux = new Tipo();
                    aux.Id = Convert.ToInt32(datos.Lector["Id"]);


                    aux.Nombre = (string)datos.Lector["Nombre"];


                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int txtsearch)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("DELETE FROM Tipo WHERE Id= '" + txtsearch + "'");
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void Editar(int txtsearch, string nombre)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("UPDATE Tipo SET Nombre = '" + nombre + "' WHERE Id = '" + txtsearch + "'");
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void Agregar(Tipo objTipos)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("insert into Tipo (Id, Nombre) values ('" + objTipos.Id + "', '" + objTipos.Nombre + "')");
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public string BuscarID(int txtsearch)
        {

            List<Tipo> lista = new List<Tipo>();
            var Tipos = new Tipo();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT *FROM Tipo where Id = " + txtsearch);
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {

                    Tipos.Id = Convert.ToInt32(datos.Lector["Id"]);
                    Tipos.Nombre = (string)datos.Lector["Nombre"];
                }
                return Tipos.Nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public bool ExisteID(int txtsearch)
        {

            List<Tipo> lista = new List<Tipo>();
            var Tipos = new Tipo();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT *FROM Tipo where Id = '" + txtsearch + "'");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {

                    if (Convert.ToInt32(datos.Lector["Id"]) == txtsearch)
                    {
                        return true;
                    }

                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public int LastID()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select MAX(Id) as LASTID  from Tipo");
                datos.ejecutarLectura();
                int cantidad = 0;
                while (datos.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    cantidad = Convert.ToInt32(datos.Lector["LASTID"]);

                }
                return cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
