using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Business
{
    public class ArticuloBusiness
    {
        public List<Articulo> Listar2()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select A.CODIGO, A.NOMBRE, A.MODELO, DESCRIPCION, PRECIO, C.Nombre Categoria, M.Nombre MARCA, IMAGENURL from Articulo A left join Categoria C on A.IdCategoria = C.Idcategoria left join MARCA M on A.IDMARCA = M.IDMARCA");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];

                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                   // aux.Marca = new Marca((string)datos.Lector["Marca"]);
                   // aux.Categoria = new Categoria((string)datos.Lector["Categoria"]);
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    //lista.Add(new Articulo((int)datos.Lector["Id"]));
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
        public List<Articulo> ListarCat()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select  DISTINCT C.Nombre Categoria from Articulo A left join Categoria C on A.IdCategoria = C.Idcategoria");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();


                    aux.Categoria = new Categoria((string)datos.Lector["Categoria"]);



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
