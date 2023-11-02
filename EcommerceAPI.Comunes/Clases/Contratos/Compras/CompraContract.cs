using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Comunes.Clases.Contratos.Compras
{
    public class CompraContract
    {
        [Key]
        public int id_compra { get; set; }
        public DateTime? fecha { get; set; }
        public double? valortotal { get; set; }
        public string? direccionentrega { get; set; }
        public int? id_cliente { get; set; }
        public int? id_estado { get; set; }
    }
}
