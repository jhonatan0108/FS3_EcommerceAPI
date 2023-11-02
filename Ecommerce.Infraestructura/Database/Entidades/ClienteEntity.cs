using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Infraestructura.Database.Entidades
{
    [Table("Cliente")]
    public class ClienteEntity
    {
        [Key]
        public int id_cliente { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string correo { get; set; } = string.Empty;
        public string direccion { get; set; } = string.Empty;
        public decimal telefono { get; set; }
    }
}
