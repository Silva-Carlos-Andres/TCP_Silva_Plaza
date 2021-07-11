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
    public partial class Tipo : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Tipo Tipos = new Tipo();
                TipoBusiness LTipos = new TipoBusiness();


                repetidor.DataSource = LTipos.Listar();
                repetidor.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int IDM = Convert.ToInt32(((Button)sender).CommandArgument);

            try
            {
                Tipo Tipos = new Tipo();
                TipoBusiness TiposBusiness = new TipoBusiness();

                TiposBusiness.eliminar(IDM);

                Response.Redirect("Tipo.aspx");

            }

            catch (Exception ex)
            {



                throw ex;
            }
        }

        protected void btneditar_Click(object sender, EventArgs e)
        {
            int IDM = Convert.ToInt32(((Button)sender).CommandArgument);
            Session["ID"] = Convert.ToInt32(IDM);
            Tipo Tipos = new Tipo();
            TipoBusiness LTipos = new TipoBusiness();
            try
            {

                txtnombre.Text = LTipos.BuscarID(IDM);

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            Dominio.Tipo Tipos = new Dominio.Tipo();
            int IDM = Convert.ToInt32(Session["ID"]);
            TipoBusiness TiposBusiness = new TipoBusiness();

            if (TiposBusiness.ExisteID(IDM))
            {
                TiposBusiness.Editar(IDM, txtnombre.Text);
                Response.Redirect("Tipo.aspx");
            }
            else
            {
                Tipos.Id = TiposBusiness.LastID() + 1;
                Tipos.Nombre = txtnombre.Text;
                TiposBusiness.Agregar(Tipos);
                Response.Redirect("Tipo.aspx");
            }
        }
    }
}