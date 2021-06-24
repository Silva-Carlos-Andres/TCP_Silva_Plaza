using System;

namespace Dominio
{
    class Compra
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Articulo IdArticulo { get; set; }
        public Decimal Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
