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
                datos.setearConsulta("select A.CODIGO, A.NOMBRE, A.MODELO, A.DESCRIPCION, A.PRECIO, C.NOMBRE Categoria, M.NOMBRE MARCA, A.IMAGENURL, P.NOMBRE Proveedor, T.Nombre Tipo, A.STOCK StockActual, A.StockMinimo, A.GananciaPorcentual, E.NOMBRE Estado from Articulo A  inner join Categoria C on A.IdCategoria = C.Idcategoria  inner join MARCA M on A.IDMARCA = M.IDMARCA inner join PROVEEDOR P ON A.IdProveedor = P.IDPROVEEDOR INNER JOIN Tipo T ON A.IdTipo = T.Id INNER JOIN ESTADO E ON A.ESTADO = E.IDESTADO");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = Convert.ToInt32((decimal)datos.Lector["Precio"]);
                    aux.Categoria = new Categoria((string)datos.Lector["Categoria"]);
                    aux.Marca = new Marca((string)datos.Lector["Marca"]);
                    //aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Proveedor = new Proveedor((string)datos.Lector["Proveedor"]);
                    aux.Tipo = new Tipo((string)datos.Lector["Tipo"]);
                    aux.StockActual = Convert.ToInt32(datos.Lector["StockActual"]);
                    aux.StockMinimo = Convert.ToInt32(datos.Lector["StockMinimo"]);
                    aux.GananciaPorcentual = Convert.ToInt32(datos.Lector["GananciaPorcentual"]);
                    aux.Estado = (string)datos.Lector["Estado"];
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
        public List<Articulo> ListarxNombre(string txtsearch)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select A.CODIGO, A.NOMBRE, A.MODELO, DESCRIPCION, PRECIO, C.Nombre Categoria, M.Nombre MARCA, IMAGENURL from Articulo A left join Categoria C on A.IdCategoria = C.Idcategoria left join MARCA M on A.IDMARCA = M.IDMARCA where A.Nombre LIKE '" + "%" + txtsearch + "%" + "'");
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
        public Articulo ListarxID(string txtsearch)
        {
            
            var Articulos = new Articulo();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select A.CODIGO, A.NOMBRE, A.MODELO, A.DESCRIPCION, A.PRECIO, C.NOMBRE Categoria, M.NOMBRE MARCA, A.IMAGENURL, P.NOMBRE Proveedor, T.Nombre Tipo, A.STOCK StockActual, A.StockMinimo, A.GananciaPorcentual, E.NOMBRE Estado from Articulo A  inner join Categoria C on A.IdCategoria = C.Idcategoria  inner join MARCA M on A.IDMARCA = M.IDMARCA inner join PROVEEDOR P ON A.IdProveedor = P.IDPROVEEDOR INNER JOIN Tipo T ON A.IdTipo = T.Id INNER JOIN ESTADO E ON A.ESTADO = E.IDESTADO where A.Codigo = '" + txtsearch + "'");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    
                    Articulos.Codigo = (string)datos.Lector["Codigo"];
                    Articulos.Nombre = (string)datos.Lector["Nombre"];
                    Articulos.Modelo = (string)datos.Lector["Modelo"];
                    Articulos.Descripcion = (string)datos.Lector["Descripcion"];
                    Articulos.Precio = Convert.ToInt32((decimal)datos.Lector["Precio"]);
                    Articulos.Categoria = new Categoria((string)datos.Lector["Categoria"]);
                    Articulos.Marca = new Marca((string)datos.Lector["Marca"]);
                    //aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    Articulos.Proveedor = new Proveedor((string)datos.Lector["Proveedor"]);
                    Articulos.Tipo = new Tipo((string)datos.Lector["Tipo"]);
                    Articulos.StockActual = Convert.ToInt32(datos.Lector["StockActual"]);
                    Articulos.StockMinimo = Convert.ToInt32(datos.Lector["StockMinimo"]);
                    Articulos.GananciaPorcentual = Convert.ToInt32(datos.Lector["GananciaPorcentual"]);
                    Articulos.Estado = (string)datos.Lector["Estado"];
                    //lista.Add(new Articulo((int)datos.Lector["Id"]));
                    
                }
                return Articulos;

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
        public bool ExisteID(string txtsearch)
        {

            //List<Articulo> lista = new List<Articulo>();
            //var Articulo = new Articulo();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT *FROM Articulo where Codigo = '" + Convert.ToString(txtsearch) + "'");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {

                    if (Convert.ToString(datos.Lector["Codigo"]) == Convert.ToString(txtsearch))
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
        public List<Articulo> ListarCod()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select  Codigo from Articulo");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();


                    aux.Codigo = (string)datos.Lector["Codigo"];



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
        public List<Articulo> ListarMod()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select  DISTINCT A.MODELO from Articulo A");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();


                    aux.Modelo = (string)datos.Lector["Modelo"];



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
        public void Agregar(Articulo objArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("insert into Articulo (Codigo, nombre, Modelo, Descripcion, IDPROVEEDOR, PRECIO, GANANCIAPORCENTUAL, IDMARCA, IDTIPO, IDCATEGORIA, STOCK, STOCKMINIMO, ESTADO, IMAGENURL) values ('" + objArticulo.Codigo + "','" + objArticulo.Nombre + "','" + objArticulo.Modelo + "','" + objArticulo.Descripcion + "','" + objArticulo.Proveedor + "','" + objArticulo.Precio + "','" + objArticulo.GananciaPorcentual + "','" + objArticulo.Marca + "','" + objArticulo.Tipo + "','" + objArticulo.Categoria + "','" + objArticulo.StockMinimo + "','" + objArticulo.Estado + "','NULL')");
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
        public void Editar(Articulo objArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("UPDATE Articulo SET NOMBRE = '" + objArticulo.Nombre + "', DESCRIPCION = '" + objArticulo.Descripcion + "', PRECIO = '" + objArticulo.Precio + "', GANANCIAPORCENTUAL = '" + objArticulo.GananciaPorcentual + "', STOCKMINIMO = '" + objArticulo.StockMinimo + "', ESTADO = '" + objArticulo.Estado + "' WHERE Codigo = '" + objArticulo.Codigo + "'");
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
    }
}
