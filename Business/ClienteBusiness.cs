using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Business;

namespace Business
{
    public class ClienteBusiness
    {
        public List<Cliente> ListarClient()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select *from cliente where Estado=1");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.Id = Convert.ToInt32(datos.Lector["IDCLIENTE"]);
                    aux.Direccion = (string)datos.Lector["DIRECCION"];

                    aux.Nombre = (string)datos.Lector["NOMBRE"];
                    aux.Email = (string)datos.Lector["EMAIL"];
                    aux.Cuit = Convert.ToInt32(datos.Lector["CUIT"]);

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
        public void agregar(Cliente Clientes)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("INSERT INTO CLIENTE( IDCLIENTE, Nombre, DIRECCION, EMAIL, CUIT, ESTADO) values('" + Clientes.Id + "','" + Clientes.Nombre + "','" + Clientes.Direccion + "', '" + Clientes.Email + "', '" + Clientes.Cuit + "', '1')");
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
                datos.setearConsulta("select MAX(IDCLIENTE) as LASTID  from CLIENTE");
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

                datos.setearConsulta("UPDATE CLIENTE set ESTADO='2' where IDCLIENTE = '" + txtsearch + "'");
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
        public bool ExisteID(int txtsearch)
        {

            List<Cliente> lista = new List<Cliente>();
            var Cliente = new Cliente();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT *FROM Cliente where IDCLIENTE = '" + Convert.ToInt32(txtsearch) + "'");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {

                    if (Convert.ToInt32(datos.Lector["IDCLIENTE"]) == Convert.ToInt32(txtsearch))
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
        public void Editar(Cliente objCliente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("UPDATE CLIENTE SET (NOMBRE = '" + objCliente.Nombre.ToString() + "', EMAIL = '" + objCliente.Email.ToString() + "', CUIT = " + objCliente.Cuit.ToString() + ", DIRECCION = '" + objCliente.Direccion.ToString() + "' ) WHERE IDCLIENTE = " + objCliente.Id.ToString() + "");
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
        public Cliente BuscarID(int txtsearch)
        {

            
            var Clientes = new Cliente();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT *FROM Cliente where IDCliente = '" + txtsearch + "'");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {

                   Clientes.Id = Convert.ToInt32(datos.Lector["IDCliente"]);
                    Clientes.Nombre = (string)datos.Lector["NOMBRE"];
                    Clientes.Direccion = (string)datos.Lector["DIRECCION"];
                    Clientes.Email = (string)datos.Lector["EMAIL"];
                   Clientes.Cuit = Convert.ToInt32(datos.Lector["CUIT"]);
                }
                return Clientes;



                
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
