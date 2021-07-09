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
            Cliente clientes = new Cliente();
            ClienteBusiness clientsBusiness = new ClienteBusiness();

            clientes.Id = clientsBusiness.LastID() + 1;
            clientes.Nombre = txtnombre.Text;
            clientes.Direccion = txtDir.Text;
            clientes.Email = txtemail.Value;
            clientes.Cuit = Convert.ToInt32(txtcuit.Value);

            clientsBusiness.agregar(clientes);
            Response.Redirect("Clientes.aspx");
        }
    }
}