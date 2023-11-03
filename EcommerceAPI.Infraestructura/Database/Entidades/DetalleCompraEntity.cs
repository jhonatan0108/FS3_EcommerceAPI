using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entidades
{
    [Table("DetalleCompra")]
    public class DetalleCompraEntity
    {
        [Key]
        public int id_detalleCompra { get; set; }
        public int id_producto { get; set; }
        public int cantidad_producto { get; set; }
        public decimal valor_unitario { get; set; }

    }
}
