namespace VideoDa.ClienteBlazor.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public int IdConsola { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Cantidad { get; set; }
        public string Imagen { get; set; }
        public string Precio { get; set;}
        public Categoria Categoria { get; set; }
        public Consola Consola { get; set; }

        public bool EsFavorito { get; set; }

    }
    
}
