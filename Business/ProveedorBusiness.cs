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
                datos.setearConsulta("select *from proveedor");
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
    }
}
