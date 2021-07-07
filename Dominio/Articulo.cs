﻿using System;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public Decimal Precio { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public int Cantidad { get; set; }

        //public Articulo(int IdArticulo)
        //{
        //    Id = IdArticulo;
        //}

    }
}
