namespace VideoDa.ClienteBlazor.Models
{
    public class Consola
    {
       public int Id { get; set; }
       public string Nombre { get; set; }
       public string Descripcion { get; set;}
       public string Serie { get; set;}
       public string Imagen { get; set; }
       public string Fabricante { get; set; }
       public string AñodeLanzamiento { get; set;}
        public Producto Producto { get; set; }
    }
}
