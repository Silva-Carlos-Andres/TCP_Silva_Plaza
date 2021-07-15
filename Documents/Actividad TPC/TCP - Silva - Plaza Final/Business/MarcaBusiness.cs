using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Dominio;

namespace Business
{
    public class MarcaBusiness
    {
        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select *from Marca");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = Convert.ToInt32(datos.Lector["IDMARCA"]);


                    aux.Nombre = (string)datos.Lector["NOMBRE"];


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

                datos.setearConsulta("DELETE FROM MARCA WHERE IDMARCA= '" + txtsearch + "'");
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

                datos.setearConsulta("UPDATE MARCA SET NOMBRE = '" + nombre + "' WHERE IDMARCA = '" + txtsearch + "'");
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
        public void Agregar( Marca objMarcas)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                datos.setearConsulta("insert into MARCA (idmarca, nombre) values ('" + objMarcas.Id + "','" + objMarcas.Nombre + "')");
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
        public  string BuscarID(int txtsearch)
        {
                       
                List<Marca> lista = new List<Marca>();
                    var Marcas = new Marca();
                AccesoDatos datos = new AccesoDatos();
                try
                {
                datos.setearConsulta("SELECT *FROM MARCA where IDMARCA = '" + txtsearch + "'");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    
                    Marcas.Id = Convert.ToInt32(datos.Lector["IDMARCA"]);
                    Marcas.Nombre = (string)datos.Lector["NOMBRE"];
                }
                return Marcas.Nombre;
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

            List<Marca> lista = new List<Marca>();
            var Marcas = new Marca();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT *FROM MARCA where IDMARCA = '" + txtsearch + "'");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {

                    if( Convert.ToInt32(datos.Lector["IDMARCA"])== txtsearch)
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
                datos.setearConsulta("select MAX(IDMARCA) as LASTID  from MARCA");
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
