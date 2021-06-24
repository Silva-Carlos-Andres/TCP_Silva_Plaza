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
    public partial class _Default : Page
    {
        public List<Articulo> lista;

        public List<Articulo> Categorias;
        public List<Articulo> LCategorias;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloBusiness Business = new ArticuloBusiness();
            try
            {
                ///CARGO EL COMBOX//////////////////////////////
                LCategorias = Business.ListarCat();
                ListCategoria.DataSource = LCategorias;
                ListCategoria.DataBind();


                lista = Business.Listar2();
                Session.Add("listadoArticulos", lista);



                string Categoria = Request.QueryString["Categoria"];
                //string Nombre = Request.QueryString["Nombre"];
                //string PDESDE = Request.QueryString["PDESDE"];
                //string PHASTA = Request.QueryString["PHASTA"];
                if (lista == null)
                {
                    lista = Business.Listar2();
                    Session.Add("listadoArticulos", lista);
                }
                if (Categoria != null)
                {
                    //lista = Business.ListarxCat(Categoria);
                    //Session.Add("listadoArticulos", lista);

                }
                //if (Nombre != null)
                //{

                //    //lista = Business.ListarxNombre(Nombre);
                //    //Session.Add("listadoArticulos", lista);

                //}

                //Session.Add("listadoArticulos", LCarrito);

                if (Categorias == null)
                    Categorias = new List<Articulo>();




            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                /*Response.Redirect("PaginaError.aspx"") A CREAR LA PAGINA DEL ERROR O UNA ALERTA, YA VEREMOS*/
            }
        }
    }
}