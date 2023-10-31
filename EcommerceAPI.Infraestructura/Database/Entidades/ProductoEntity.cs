﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entidades
{
    [Table("Producto")]
    public class ProductoEntity
    {
        [Key]
        public int id_producto {  get; set; }
        public float valor { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public int stock { get; set; }
        public int id_categoria { get; set; }
        public int id_estado { get; set; }
        public int categoria_padre { get; set; }
    }
}