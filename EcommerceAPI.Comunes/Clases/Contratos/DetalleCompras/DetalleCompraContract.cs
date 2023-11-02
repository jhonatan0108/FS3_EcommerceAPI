namespace EcommerceAPI.Comunes.Clases.Contratos.DetalleCompras
{
    public class DetalleCompraContract
    {
        public int id_detallecompra { get; set; }
        public int cantidad { get; set; }
        public string valorunitario { get; set; }
        public int? id_compra { get; set; }
        public int id_producto { get; set; }

    }
}
