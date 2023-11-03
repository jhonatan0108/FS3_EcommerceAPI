namespace EcommerceAPI.Comunes.Clases.Contratos.Carritos
{
    public class DetalleCompraContract
    {
        public int id_detalleCompra { get; set; }
        public int id_producto { get; set; }
        public int cantidad_producto { get; set; }
        public decimal valor_unitario { get; set; }
    }
}
