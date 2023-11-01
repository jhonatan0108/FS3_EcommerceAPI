 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entidades
{
    [Table("Estado")]
    public class EstadoEntity
    {
        [Key]
        public int id_estado { get; set; }
        public string descripcion { get; set; }
    }
}
