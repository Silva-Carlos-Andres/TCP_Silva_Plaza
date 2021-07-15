using System;

namespace Dominio
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int[] Articulos { get; set; }
        public Vendedor Vendedor { get; set; }
        public Decimal Monto { get; set; }
    }
}
