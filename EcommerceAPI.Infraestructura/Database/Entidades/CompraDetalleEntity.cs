

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entidades
{
    [Table("DetalleCompra")]
    public class CompraDetalleEntity
    {
        [Key]
        public int id_detallecompra { get; set; }

        public int cantidad { get; set; }

        public double valorunitario { get; set; }

        public int id_compra { get; set; }

        public int id_producto { get; set; }

    }
}
