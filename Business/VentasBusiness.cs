using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class VentasBusiness
    {
        public List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Fecha, Nombre, Apellido, Precio FROM Ventas");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Venta aux = new Venta();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Vendedor = new Vendedor((string)datos.Lector["Nombre"], (string)datos.Lector["Apellido"]);
                    aux.Monto = (Decimal)datos.Lector["Precio"];

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

        public List<Venta> BuscarVentaPorId(int id)
        {
            List<Venta> lista = new List<Venta>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM Ventas WHERE Id = " + id.ToString());
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Venta aux = new Venta();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Vendedor = new Vendedor((string)datos.Lector["Nombre"], (string)datos.Lector["Apellido"]);
                    aux.Monto = (Decimal)datos.Lector["Precio"];

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

        //public void NuevaVenta(Venta venta)
        //{
        //    AccesoDatos datos = new AccesoDatos();

        //    try
        //    {
        //        datos.setearConsulta("EXEC SP_NuevaVenta " + venta..ToString() +", "+ venta.IdCliente.ToString() + ", " + venta.Monto.ToString() + ", " + venta.Fecha.ToString());
        //        datos.ejecutarLectura();

        //        for(var i=0; i < venta.Articulos.Length; i= i+2)
        //        {
        //            datos.setearConsulta("EXEC SP_NuevaListaArticuloVenta " + venta.Id.ToString() + ", " + venta.Articulos[i].ToString() + ", " + venta.Articulos[i + 1].ToString());
        //            datos.ejecutarLectura();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}

    }

}
