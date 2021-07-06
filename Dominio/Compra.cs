using System;

namespace Dominio
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Articulo IdArticulo { get; set; }
        public Proveedor IdProveedor { get; set; }
        public Decimal Precio { get; set; }
        public int Cantidad { get; set; }

    }
}
