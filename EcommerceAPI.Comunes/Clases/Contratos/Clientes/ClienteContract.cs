﻿namespace EcommerceAPI.Comunes.Clases.Contratos.Clientes
{
    public class ClienteContract
    {
        public int id_cliente { get; set; }
        public string? nombre { get; set; }
        public string? password{ get; set; }
        public string? correo { get; set; }
        public string? direccionfacturacion { get; set; }
        public decimal telefono { get; set; }
    }
}
