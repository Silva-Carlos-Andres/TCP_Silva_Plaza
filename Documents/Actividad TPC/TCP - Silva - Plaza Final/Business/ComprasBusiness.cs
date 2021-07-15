using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Dominio;

namespace Business
{
    public class ComprasBusiness
    {
        public List<Compra> Listar()
        {
            List<Compra> lista = new List<Compra>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM COMPRA");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Compra aux = new Compra();

                    aux.Id = (int)datos.Lector["ID"];
                    aux.Fecha = (DateTime)datos.Lector["FECHA"];
                    //aux.IdArticulo = new Articulo((int)datos.Lector["IDARTICULO"]);
                    //aux.IdProveedor = new Proveedor((int)datos.Lector["IDPROVEEDOR"]);
                    aux.Precio = (Decimal)datos.Lector["PRECIO"];
                    aux.Cantidad = (int)datos.Lector["CANTIDAD"];

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
