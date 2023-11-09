 
namespace EcommerceAPI.Comunes.Clases.Contratos.ComprasDetalle
{
    public class CompraDetalleContract
    {
        public int id_detallecompra { get; set; }

        public int cantidad { get; set; }

        public double valorunitario { get; set; }

        public int id_compra { get; set; }

        public int id_producto { get; set; }
    }
}
