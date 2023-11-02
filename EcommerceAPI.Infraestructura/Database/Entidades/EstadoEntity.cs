using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Infraestructura.Database.Entidades
{
    [Table("Estado")]
    public class EstadoEntity
    {
        [Key]
        public int? id_estado { get; set; }
        public string descripcion { get; set; }
       
    }
}