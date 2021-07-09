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
    public partial class Proveedores : System.Web.UI.Page
    {
        public List<Proveedor> Proveedors;
        protected void Page_Load(object sender, EventArgs e)
        {
          

            //ProveedorBusiness Business = new ProveedorBusiness();
            try
            {
                //Proveedors = Business.ListarProv();
                ProveedorBusiness PBusiness = new ProveedorBusiness();
                List<Proveedor> LProveedores = PBusiness.ListarProv();
                repetidor.DataSource = LProveedores;
                repetidor.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void btn_agregar_Click(object sender, ImageClickEventArgs e)
        {
            Proveedor proveedores = new Proveedor();
            ProveedorBusiness proveedorBusiness = new ProveedorBusiness();

            proveedores.Id = proveedorBusiness.LastID() + 1;
            proveedores.Nombre = txtnombre.Text;
            proveedores.Direccion = txtDir.Text;
            proveedores.Email = txtemail.Value;
            proveedores.CUIT = Convert.ToInt32(txtcuit.Value);

            proveedorBusiness.agregar(proveedores);
            Response.Redirect("Proveedores.aspx");
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int IDP = Convert.ToInt32(((Button)sender).CommandArgument);
            
            try
            {
                Proveedor proveedores = new Proveedor();
                ProveedorBusiness proveedorBusiness = new ProveedorBusiness();

                proveedorBusiness.eliminar(IDP);

                Response.Redirect("Proveedores.aspx");

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    
}