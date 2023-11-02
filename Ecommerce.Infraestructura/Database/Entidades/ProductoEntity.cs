using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Infraestructura.Database.Entidades
{
    [Table("producto")]
    public class ProductoEntity
    {
        [Key]
        public int id_producto { get; set; }
        public string descripcion { get; set; } = string.Empty;
        public double valor { get; set; }
        public string imagen { get; set; } = string.Empty;
        public int id_estado { get; set; }
        public int stock { get; set; }
    }
}
