﻿namespace VideoDa.ClienteBlazor.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public Producto Producto { get; set; }
    }
}
