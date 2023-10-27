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
        public string contraseña_encriptada { get; set; }
        public byte[] salt { get; set; }
        public string correo { get; set; }
        public string direccion_facturacion { get; set; }
        public string telefono { get; set; }
    }
}
