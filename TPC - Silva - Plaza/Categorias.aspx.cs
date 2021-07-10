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
    public partial class Categorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                
                CategoriaBusiness CategoriasBusiness = new CategoriaBusiness();


                ListCategoria.DataSource = CategoriasBusiness.Listar();
                ListCategoria.DataBind();
            
            
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            Categoria Categorias = new Categoria();
            int IDM = Convert.ToInt32(Session["ID"]);
            CategoriaBusiness CategoriasBusiness = new CategoriaBusiness();

            if (CategoriasBusiness.ExisteID(IDM))
            {
                CategoriasBusiness.Editar(IDM, txtnombre.Text);
                Response.Redirect("Categorias.aspx");
            }
            else
            {
                Categorias.Id = CategoriasBusiness.LastID() + 1;
                Categorias.Nombre = txtnombre.Text;
                CategoriasBusiness.Agregar(Categorias);
                Response.Redirect("Categorias.aspx");
            }
        }

        protected void btneditar_Click(object sender, EventArgs e)
        {
            int IDM = Convert.ToInt32(((Button)sender).CommandArgument);
            Session["ID"] = Convert.ToInt32(IDM);
            Categoria Categorias = new Categoria();
            CategoriaBusiness LCategorias = new CategoriaBusiness();
            try
            {




                txtnombre.Text = LCategorias.BuscarID(IDM);




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
                Categoria Categorias = new Categoria();
                CategoriaBusiness CategoriasBusiness = new CategoriaBusiness();

                CategoriasBusiness.eliminar(IDM);

                Response.Redirect("Categorias.aspx");

            }

            catch (Exception ex)
            {



                throw ex;
            }
        }

 
    }
    
}