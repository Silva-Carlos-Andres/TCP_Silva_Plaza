using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vendedor
    {
        //public int Id { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FNacimiento { get; set; }
        public int CUIT { get; set; }
        public bool Estado { get; set; }
        public string Direccion { get; set; }
        public decimal Sueldo { get; set; }

        //public Vendedor(int IdVendedor)
        //{
        //    Id = IdVendedor;
        //}

        public Vendedor(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public Vendedor() { }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
