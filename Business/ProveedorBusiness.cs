using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class ProveedorBusiness
    {
        public List<Proveedor> ListarProv()
        {
            List<Proveedor> lista = new List<Proveedor>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select *from proveedor where Estado=1");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Proveedor aux = new Proveedor();
                    //aux.Id = (int)datos.Lector["IDPROVEEDOR"];
                    aux.Id = Convert.ToInt32(datos.Lector["IDPROVEEDOR"]);
                    aux.Direccion = (string)datos.Lector["DIRECCION"];

                    aux.Nombre = (string)datos.Lector["NOMBRE"];
                    aux.Email = (string)datos.Lector["EMAIL"];
                    aux.CUIT = Convert.ToInt32(datos.Lector["CUIT"]);

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
        public List<Proveedor> BuscarProv(string txtsearch)
        {
            List<Proveedor> lista = new List<Proveedor>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select *from proveedor where IDPROVEEDOR = '" + txtsearch + "'");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Proveedor aux = new Proveedor();
                    //aux.Id = (int)datos.Lector["IDPROVEEDOR"];
                    aux.Id = Convert.ToInt32(datos.Lector["IDPROVEEDOR"]);
                    aux.Direccion = (string)datos.Lector["DIRECCION"];

                    aux.Nombre = (string)datos.Lector["NOMBRE"];
                    aux.Email = (string)datos.Lector["EMAIL"];
                    aux.CUIT = Convert.ToInt32(datos.Lector["CUIT"]);

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
        public void agregar(Proveedor Proveedores)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                datos.setearConsulta("INSERT INTO PROVEEDOR( Nombre, DIRECCION, EMAIL, CUIT, ESTADO) values('" + Proveedores.Nombre + "','" + Proveedores.Direccion + "', '" + Proveedores.Email + "', '" + Proveedores.CUIT + "', '1')");
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
        public void eliminar(int txtsearch)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("UPDATE PROVEEDOR set ESTADO='2' where IDPROVEEDOR = '" + txtsearch + "'");
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
        public int LastID()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select MAX(IDPROVEEDOR) as LASTID  from PROVEEDOR");
                datos.ejecutarLectura();
                int cantidad =0;
                while (datos.Lector.Read())
                {
                    Proveedor aux = new Proveedor();
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
