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
    public partial class Ventas : System.Web.UI.Page
    {
        public List<Venta> ventas;
        protected void Page_Load(object sender, EventArgs e)
        {

            VentasBusiness Business = new VentasBusiness();
            try
            {
                ventas = Business.Listar();
            }
            catch (Exception ex)
            {
                throw ex;                
            }

        }

    }
}