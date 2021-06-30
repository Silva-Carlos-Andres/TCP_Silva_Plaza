using System;

namespace Dominio
{
    class Venta
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public Articulo IdArticulo { get; set; }
        public Vendedor IdVendedor { get; set; }
        public Decimal Precio { get; set; }
    }
}
