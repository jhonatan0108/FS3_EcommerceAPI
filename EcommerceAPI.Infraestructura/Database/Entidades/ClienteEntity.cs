using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entidades
{
    [Table("Cliente")]
    public class ClienteEntity
    {
        [Key]
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string password { get; set; }
        public string correo { get; set; }
        public string direccionfacturacion { get; set; }
        public decimal telefono { get; set; }
    }
}
