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
    public partial class Marcas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Marca Marcas = new Marca();
                MarcaBusiness LMarcas = new MarcaBusiness();


                repetidor.DataSource = LMarcas.Listar();
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
                Marca Marcas = new Marca();
                MarcaBusiness MarcasBusiness = new MarcaBusiness();

                MarcasBusiness.eliminar(IDM);

                Response.Redirect("Marcas.aspx");

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
            Marca Marcas = new Marca();
            MarcaBusiness LMarcas = new MarcaBusiness();
            try
            {
                

              

                txtnombre.Text = LMarcas.BuscarID(IDM);




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
            Marca Marcas = new Marca();
            int IDM = Convert.ToInt32(Session["ID"]);
            MarcaBusiness MarcasBusiness = new MarcaBusiness();

            if (MarcasBusiness.ExisteID(IDM))
            {
                MarcasBusiness.Editar(IDM, txtnombre.Text);
                Response.Redirect("Marcas.aspx");
            }
            else
            { 
            Marcas.Id = MarcasBusiness.LastID() + 1;
            Marcas.Nombre = txtnombre.Text;
                MarcasBusiness.Agregar(Marcas);
            Response.Redirect("Marcas.aspx");
            }
        }
    }
    
}