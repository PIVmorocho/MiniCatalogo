namespace MiniCatalogo.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public string UrlImagen { get; set; } = "https://img.freepik.com/foto-gratis/joven-que-trabaja-oficina-colega_23-2147785029.jpg?t=st=1772074702~exp=1772078302~hmac=81a2c94bf335d19ef1eb271970061d49db60ceb4f08428132e27919e381d977d&w=740";
    }
}