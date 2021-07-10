using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Business;

namespace TPC___Silva___Plaza
{
    public partial class Clientes : System.Web.UI.Page
    {
        public List<Cliente> Clients;
        public Cliente OClientes;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ClienteBusiness CBusiness = new ClienteBusiness();
                List<Cliente> LClientes = CBusiness.ListarClient();
                repetidor.DataSource = LClientes;
                repetidor.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int IDP = Convert.ToInt32(((Button)sender).CommandArgument);

            try
            {
                Cliente clientes = new Cliente();
                ClienteBusiness clientsBusiness = new ClienteBusiness();

                clientsBusiness.eliminar(IDP);

                Response.Redirect("Clientes.aspx");

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btn_agregar_Click(object sender, ImageClickEventArgs e)
        {
            

            
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {

        }

        protected void btneditar_Click(object sender, EventArgs e)
        {
            int IDM = Convert.ToInt32(((Button)sender).CommandArgument);
            Session["ID"] = Convert.ToInt32(IDM);
            Cliente Clientes = new Cliente();
            ClienteBusiness LClientes = new ClienteBusiness();
            try
            {




                Clientes = LClientes.BuscarID(IDM);
                txtnombre.Text = Clientes.Nombre;
                txtemail.Value = Clientes.Email;
                txtcuit1.Text = Convert.ToString(Clientes.Cuit);
                txtDir.Text = Clientes.Direccion;
                    



            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnagregar_Click1(object sender, EventArgs e)
        {
            Cliente clientes = new Cliente();
            int IDM = Convert.ToInt32(Session["ID"]);
            ClienteBusiness clientsBusiness = new ClienteBusiness();

            clientes.Nombre = txtnombre.Text;
            clientes.Direccion = txtDir.Text;
            clientes.Email = txtemail.Value;
            clientes.Cuit = Convert.ToInt32(txtcuit1.Text);

            if (clientsBusiness.ExisteID(IDM))
            {
                clientes.Id = IDM;
                clientsBusiness.Editar(clientes);
                Response.Redirect("Clientes.aspx");
            }
            else
            {

                clientes.Id = clientsBusiness.LastID() + 1;
                clientsBusiness.agregar(clientes);
                Response.Redirect("Clientes.aspx");
            }
        }
    }
}