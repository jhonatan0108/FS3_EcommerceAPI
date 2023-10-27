namespace EcommerceAPI.Comunes.Clases.Contratos.Clientes
{
    public class ClienteContract
    {
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }
        public string direccion_facturacion { get; set; }
        public string telefono { get; set; }
    }
}
