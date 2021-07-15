using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Business;

namespace Business
{
    public class VendedorBusiness
    {
        public List<Vendedor> ListarVendedor()
        {
            List<Vendedor> lista = new List<Vendedor>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select *from vendedor");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Vendedor aux = new Vendedor();
                    aux.DNI = Convert.ToInt32(datos.Lector["DNI"]);
                    aux.Direccion = (string)datos.Lector["DIRECCION"];

                    aux.Nombre = (string)datos.Lector["NOMBRE"];
                    aux.Apellido = (string)datos.Lector["APELLIDO"];
                    aux.Email = (string)datos.Lector["EMAIL"];
                    //aux.DNI = Convert.ToInt32(datos.Lector["DNI"]);
                    aux.FNacimiento = (DateTime)datos.Lector["FNAC"];
                    aux.Sueldo = (decimal)datos.Lector["SUELDO"];

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
        public void agregar(Vendedor Vendedores)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("INSERT INTO VENDEDOR(  DNI, NOMBRE, Apellido, DIRECCION, EMAIL, APELLIDO, FechaNacimiento, CUIT, Sueldo) values('" + Vendedores.DNI + "','" + Vendedores.Nombre + "','" + Vendedores.Apellido + "','" + Vendedores.Direccion + "', '" + Vendedores.Email + "', '1', '" + Vendedores.Apellido + "','" + Vendedores.FNacimiento + "' ,'" + Vendedores.CUIT + "' ,'" + Vendedores.Sueldo + "' )");
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

                datos.setearConsulta("UPDATE VENDEDOR SET NOMBRE = '" + nombre + "' WHERE IDMARCA = '" + txtsearch + "'");
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

        //public int LastID()
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        datos.setearConsulta("select MAX(IDVENDEDOR) as LASTID  from VENDEDOR");
        //        datos.ejecutarLectura();
        //        int cantidad = 0;
        //        while (datos.Lector.Read())
        //        {
        //            Cliente aux = new Cliente();
        //            cantidad = Convert.ToInt32(datos.Lector["LASTID"]);

        //        }
        //        return cantidad;
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

        public void eliminar(int txtsearch)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("UPDATE VENDEDOR set ESTADO='2' where DNI = '" + txtsearch + "'");
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
        public void BuscarDNI(int txtsearch)
        {
            AccesoDatos datos = new AccesoDatos();

            List<Vendedor> lista = new List<Vendedor>();
            
            try
            {

                datos.setearConsulta("SELECT *FROM VENDEDOR where DNI = '" + txtsearch + "'");
                datos.ejectutarAccion();
                Vendedor aux = new Vendedor();
                aux.DNI = Convert.ToInt32(datos.Lector["DNI"]);
                aux.Direccion = (string)datos.Lector["DIRECCION"];

                aux.Nombre = (string)datos.Lector["NOMBRE"];
                aux.Apellido = (string)datos.Lector["APELLIDO"];
                aux.Email = (string)datos.Lector["EMAIL"];
                //aux.DNI = Convert.ToInt32(datos.Lector["DNI"]);
                aux.FNacimiento = (DateTime)datos.Lector["FNAC"];
                aux.Sueldo = (decimal)datos.Lector["SUELDO"];
                lista.Add(aux);
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

            List<Vendedor> lista = new List<Vendedor>();
            var Vendedors = new Vendedor();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT *FROM Vendedor where DNI = '" + txtsearch + "'");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    if (Convert.ToInt32(datos.Lector["DNI"]) == txtsearch)
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
    }
}
