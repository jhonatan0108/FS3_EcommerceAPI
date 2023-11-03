namespace EcommerceAPI.Comunes.Clases.Contratos.DetalleCompra
{
    public class DetalleCompraContract
    {
        public int id_detalleCompra { get; set; }
        public int id_producto { get; set; }
        public int cantidad_producto { get; set; }
        public decimal totalDetalle { get; set; }
    }
}
