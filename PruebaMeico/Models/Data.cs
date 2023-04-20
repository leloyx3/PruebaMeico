namespace PruebaMeico.Models
{
    public class Data
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public List<Telefono> Telefonos { get; set; }
        public string Email { get; set; }
    }

    public class Telefono
    {
        public string TipoTelefono { get; set; }
        public string NumeroTelefono { get; set; }
    }
}
