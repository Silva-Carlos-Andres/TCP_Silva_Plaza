using System;

namespace Dominio
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        
        public Categoria(string nombre)
        {
            Nombre = nombre;
        }
        public override string ToString()
        {
            return Nombre;
        }
        public Categoria() { }
        
    }
}
