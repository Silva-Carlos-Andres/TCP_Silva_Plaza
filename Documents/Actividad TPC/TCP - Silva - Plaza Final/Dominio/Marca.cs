namespace Dominio
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Marca(string nombre)
        {
            Nombre = nombre;
        }
        public Marca() { }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
