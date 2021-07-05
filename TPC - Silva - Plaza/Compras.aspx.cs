using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Dominio;

namespace TPC___Silva___Plaza
{
    public partial class Compras : System.Web.UI.Page
    {
        public List<Proveedor> SProveedor;
        public List<Proveedor> LProveedores;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ProveedorBusiness Business = new ProveedorBusiness();

            try
            {
                ListProv.DataSource = Business.ListarProv();
                List<Proveedor> ListProveedores = Business.ListarProv();
                Session["ListaProveedores"] = ListProveedores;
                ListProv.DataTextField = "Nombre";
                ListProv.DataValueField = "ID";
                ListProv.DataBind();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        protected void btnContinue_Click(object sender, EventArgs e)
        {
            ProveedorBusiness Business = new ProveedorBusiness();
            

            txtid.Visible = true;
            txtid.EnableViewState = true;
            txtnombre.Visible = true;
            txtnombre.EnableViewState = true;
            txtemail.Visible = true;
            txtemail.EnableViewState = true;
            txtcuit.Visible = true;
            txtcuit.EnableViewState = true;

            string algo = (string)Session["id"];
            SProveedor = Business.BuscarProv(algo);

            SelectProveedores.DataSource = SProveedor;
            SelectProveedores.DataBind();
        }

        protected void ListProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(ListProv.SelectedItem.Value);
            txtnombre.Text = Convert.ToString(((List<Proveedor>)Session["ListaProveedores"]).FindAll(x => x.Id == id));
        }
    }
}