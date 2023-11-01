using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entidades
{
    [Table("Categoria")]
    public class CategoriaEntity
    {
        [Key]
        public int id_categoria { get; set; }
        public int nombre { get; set; }
        public int descripcion { get; set; }
        public int categoria_padre { get; set; }
    }
}
