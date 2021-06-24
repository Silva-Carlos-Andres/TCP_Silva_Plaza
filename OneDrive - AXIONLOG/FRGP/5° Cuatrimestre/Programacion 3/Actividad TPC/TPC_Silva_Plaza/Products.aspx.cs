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
        public List<Categoria> lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriaBusiness negocio = new CategoriaBusiness();
            try
            {
                lista = negocio.Listar();
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}