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
                    aux.Id = Convert.ToInt32(datos.Lector["IDVENDEDOR"]);
                    aux.Direccion = (string)datos.Lector["DIRECCION"];

                    aux.Nombre = (string)datos.Lector["NOMBRE"];
                    aux.Apellido = (string)datos.Lector["APELLIDO"];
                    aux.Email = (string)datos.Lector["EMAIL"];
                    aux.DNI = Convert.ToInt32(datos.Lector["DNI"]);
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

                datos.setearConsulta("INSERT INTO VENDEDOR( IDVENDEDOR, Nombre, DIRECCION, EMAIL, DNI, ESTADO, APELLIDO, FNAC) values('" + Vendedores.Id + "','" + Vendedores.Nombre + "','" + Vendedores.Direccion + "', '" + Vendedores.Email + "', '" + Vendedores.DNI + "', '1', '" + Vendedores.Apellido + "','" + Vendedores.FNacimiento + "' )");
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
                datos.setearConsulta("select MAX(IDVENDEDOR) as LASTID  from VENDEDOR");
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
        public void eliminar(int txtsearch)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("UPDATE VENDEDOR set ESTADO='2' where IDVENDEDOR = '" + txtsearch + "'");
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
        public void BuscarID(int txtsearch)
        {
            AccesoDatos datos = new AccesoDatos();

            List<Vendedor> lista = new List<Vendedor>();
            
            try
            {

                datos.setearConsulta("SELECT *FROM VENDEDOR where IDVENDEDOR = '" + txtsearch + "'");
                datos.ejectutarAccion();
                Vendedor aux = new Vendedor();
                aux.Id = Convert.ToInt32(datos.Lector["IDVENDEDOR"]);
                aux.Direccion = (string)datos.Lector["DIRECCION"];

                aux.Nombre = (string)datos.Lector["NOMBRE"];
                aux.Apellido = (string)datos.Lector["APELLIDO"];
                aux.Email = (string)datos.Lector["EMAIL"];
                aux.DNI = Convert.ToInt32(datos.Lector["DNI"]);
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
    }
}
