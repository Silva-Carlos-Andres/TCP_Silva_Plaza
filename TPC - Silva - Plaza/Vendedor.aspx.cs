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
    public partial class Vendedor : System.Web.UI.Page
    {
        public List<Vendedor> Vendedrs;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //VendedorBusiness VBusiness = new VendedorBusiness();
                //List<Vendedor> LVendedores = VBusiness.ListarVendedor();


                Vendedor Vendedores = new Vendedor();
                VendedorBusiness LVendedores = new VendedorBusiness();


                repetidor.DataSource = LVendedores.ListarVendedor();
                repetidor.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {

            Vendedor Vendedores = new Vendedor();
            int DNI = Convert.ToInt32(Session["DNI"]);
            VendedorBusiness VendeBusiness = new VendedorBusiness();

            if (VendeBusiness.ExisteID(DNI))
            {

                Vendedores.Nombre = txtnombre.Text;
                Vendedores.Direccion = txtDir.Text;
                Vendedores.Email = txtemail.Value;
                Vendedores.Cuit = Convert.ToInt32(txtcuit.Value);

                VendeBusiness.Editar(DNI, Vendedores);
                Response.Redirect("Marcas.aspx");
            }
            VendeBusiness.agregar(Vendedores);
            Response.Redirect("Clientes.aspx");
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int DNI = Convert.ToInt32(((Button)sender).CommandArgument);

            try
            {
                Vendedor Vendedores = new Vendedor();
                VendedorBusiness VendeBusiness = new VendedorBusiness();

                VendeBusiness.eliminar(DNI);

                Response.Redirect("Vendedor.aspx");

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btneditar_Click(object sender, EventArgs e)
        {
            int DNI = Convert.ToInt32(((Button)sender).CommandArgument);

            try
            {
                Vendedor Vendedores = new Vendedor();
                VendedorBusiness VendeBusiness = new VendedorBusiness();

                VendeBusiness.eliminar(DNI);

                Response.Redirect("Vendedor.aspx");

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
    
}