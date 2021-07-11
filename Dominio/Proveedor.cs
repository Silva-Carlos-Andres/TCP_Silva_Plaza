namespace Dominio
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
        public int CUIT { get; set; }
        //public Proveedor(int IdProveedor)
        //{
        //    Id = IdProveedor;
        //}
        public Proveedor(string nombre)
        {
            Nombre = nombre;
        }
        public Proveedor() { }
        public override string ToString()
        {
            return Nombre;
        }
    }

}
