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
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Articulo> articulos;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloBusiness Business = new ArticuloBusiness();
            try
            {
                articulos = Business.Listar2();
                articulos.Sort((x, y) => (x.StockActual - x.StockMinimo).CompareTo(y.StockActual - y.StockMinimo));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}