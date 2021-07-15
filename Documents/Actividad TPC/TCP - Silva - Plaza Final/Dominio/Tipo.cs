using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Tipo(string nombre)
        {
            Nombre = nombre;
        }
        public Tipo(){ }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
