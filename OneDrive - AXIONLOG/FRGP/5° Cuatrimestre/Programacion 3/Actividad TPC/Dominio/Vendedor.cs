using System;

namespace Dominio
{
    class Vendedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FNacimiento { get; set; }
        public bool Estado { get; set; }
        public int DNI { get; set; }
        public decimal Sueldo { get; set; }
    }
}
