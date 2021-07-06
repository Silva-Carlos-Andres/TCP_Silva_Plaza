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
        public List<Compra> LCompras;
        public List<Articulo> LArticulos;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ProveedorBusiness PBusiness = new ProveedorBusiness();
            

            try
            {
                if (!IsPostBack)
                { 

                ListProv.DataSource = PBusiness.ListarProv();
                List<Proveedor> ListProveedores = PBusiness.ListarProv();
                Session["ListaProveedores"] = ListProveedores;
                ListProv.DataTextField = "Nombre";
                ListProv.DataValueField = "ID";
                ListProv.DataBind();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void ListProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComprasBusiness CBusiness = new ComprasBusiness();
            
            List<Compra> LCompras = CBusiness.Listar();
            Session["ListaCompras"] = LCompras;

            ComprasBusiness ABusiness = new ComprasBusiness();

            List<Compra> LArticulos = ABusiness.Listar();
            Session["ListaArticulos"] = LArticulos;

            dgvArticulos.DataSource = Session["ListaArticulos"];
            dgvArticulos.DataBind();

            int id = int.Parse(ListProv.SelectedItem.Value);
            DgvProveedor.DataSource = ((List<Proveedor>)Session["ListaProveedores"]).FindAll(x => x.Id == id);
            DgvProveedor.DataBind();


            repetidor.DataSource = LCompras;
            repetidor.DataBind();
        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}