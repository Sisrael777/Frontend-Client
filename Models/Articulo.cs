﻿namespace VideoDa.ClienteBlazor.Models
{
    public class Articulo
    {
        public int Id { get; set; }
        public int IdConsola { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }

        public string Precio { get; set; }

        public bool EsFavorito { get; set; }
    }
}
