using System;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public Decimal Precio { get; set; }
        public int GananciaPorcentual { get; set; }
        public Tipo Tipo { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public Proveedor Proveedor { get; set; }
        public string ImagenUrl { get; set; }
        public string Estado { get; set; }

        //public Articulo(int IdArticulo)
        //{
        //    Id = IdArticulo;
        //}

    }
}
