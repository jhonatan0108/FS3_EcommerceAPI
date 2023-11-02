using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Infraestructura.Database.Entidades
{
    [Table("estado")]
    public class EstadoEntity
    {
        [Key]
        public int id_estado { get; set; }
        public string descripcion { get; set; } = string.Empty;
        public string tabla { get; set; } = string.Empty;
    }
}
