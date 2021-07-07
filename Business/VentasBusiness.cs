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
                datos.setearConsulta("SELECT * FROM VENTA");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Venta aux = new Venta();

                    aux.Id = (int)datos.Lector["ID"];
                    aux.Fecha = (DateTime)datos.Lector["FECHA"];
                    //aux.Vendedor = new Vendedor((int)datos.Lector["IDVENDEDOR"]);
                    aux.Precio = (Decimal)datos.Lector["PRECIO"];

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
