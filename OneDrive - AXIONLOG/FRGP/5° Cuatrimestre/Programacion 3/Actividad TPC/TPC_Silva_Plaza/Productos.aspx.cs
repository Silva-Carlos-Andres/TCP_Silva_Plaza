using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Business;

namespace TPC_Silva_Plaza
{
    public partial class About : Page
    {
        public List<Articulo> lista;
        public List<Articulo> lista2;
        protected void Page_Load(object sender, EventArgs e)
        {
            //CategoriaBusiness negocio = new CategoriaBusiness();

            ///Prueba de actualizacion
            ArticuloBusiness Business = new ArticuloBusiness();
            try
            {
                lista = Business.Listar2();
                Session.Add("listadoArticulos", lista);


                //lista2 = Business.Listar2();
                //ListArticulo.DataSource = lista2;
                //ListArticulo.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}