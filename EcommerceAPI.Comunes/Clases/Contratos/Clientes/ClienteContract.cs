namespace EcommerceAPI.Comunes.Clases.Contratos.Clientes
{
    public class ClienteContract
    {
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string contrasena { get; set; }
        public string correo { get; set; }
        public string direccioncliente { get; set; }
        public int telefono { get; set; }
    }
}
