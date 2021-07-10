using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class CategoriaBusiness
    {
        public List<Categoria> Listar()
        {
            List<Categoria> listac = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT * FROM CATEGORIA");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria(); 
                    aux.Id = Convert.ToInt32(datos.Lector["IDCATEGORIA"]);
                    aux.Nombre = (string)datos.Lector["NOMBRE"];
                    listac.Add(aux);
                }
                return listac;
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

                datos.setearConsulta("DELETE FROM Categoria WHERE IDCategoria= '" + Convert.ToInt32(txtsearch) + "'");
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

                datos.setearConsulta("UPDATE Categoria SET NOMBRE = '" + nombre + "' WHERE IDCategoria = '" + Convert.ToInt32(txtsearch) + "'");
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
        public void Agregar(Categoria objCategoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("insert into Categoria (idCategoria, nombre) values ('" + objCategoria.Id + "','" + objCategoria.Nombre + "')");
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

            List<Categoria> lista = new List<Categoria>();
            var Categoria = new Categoria();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT *FROM Categoria where IDCategoria = '" + Convert.ToInt32(txtsearch) + "'");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {

                    Categoria.Id = Convert.ToInt32(datos.Lector["IDCategoria"]);
                    Categoria.Nombre = (string)datos.Lector["NOMBRE"];
                }
                return Categoria.Nombre;
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

            List<Categoria> lista = new List<Categoria>();
            var Categoria = new Categoria();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT *FROM Categoria where IDCategoria = '" + Convert.ToInt32(txtsearch) + "'");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {

                    if (Convert.ToInt32(datos.Lector["IDCategoria"]) == Convert.ToInt32(txtsearch))
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
                datos.setearConsulta("select MAX(IDCategoria) as LASTID  from Categoria");
                datos.ejecutarLectura();
                int cantidad = 0;
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
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
