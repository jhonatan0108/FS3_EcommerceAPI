using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entidades
{

    [Table("Compra")]
    public class CompraEntity
    {
        [Key]
        [ForeignKey("id_client")]
        public int id_compras { get; set; }
        public DateTime fecha { get; set; }
        public double valortotal { get; set; }
        public string? direccionentrega { get; set; }
        //public int id_cliente { get; set; }//
        public int id_estado { get; set; }

        public int Id { get; set; }
        // otras propiedades...

        public int id_client { get; set; } // Esta es la clave externa

        
        
    }

    


}

