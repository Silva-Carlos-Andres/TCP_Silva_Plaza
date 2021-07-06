using System;

namespace Dominio
{
    public class Venta
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public Articulo Articulo { get; set; }
        public Vendedor Vendedor { get; set; }
        public Decimal Precio { get; set; }
    }
}
