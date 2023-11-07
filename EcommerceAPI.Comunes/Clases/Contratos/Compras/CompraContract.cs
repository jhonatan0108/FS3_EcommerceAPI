using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Comunes.Clases.Contratos.Compras
{
    public class CompraContract
    {
        public int id_compra { get; set; }
        public int id_cliente { get; set; }
        public DateOnly fecha { get; set; }
        public decimal valor_total { get; set; }
        public string direccion_entrega { get; set; }
        public int id_estado { get; set; }
        public List<DetalleCompraEntity> detalles { get; set; }
    }
}
