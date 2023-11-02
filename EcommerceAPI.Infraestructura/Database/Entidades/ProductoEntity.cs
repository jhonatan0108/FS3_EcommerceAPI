using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Database.Entidades
{
    [Table("Producto")]
    public class ProductoEntity
    {
        [Key]
        public int id_producto { get; set; }
        public string descripcion { get; set; }
        public string valor { get; set; }
        public string imagen { get; set; }
        public string id_estado { get; set; }
        public decimal stock { get; set; }
    }
}
