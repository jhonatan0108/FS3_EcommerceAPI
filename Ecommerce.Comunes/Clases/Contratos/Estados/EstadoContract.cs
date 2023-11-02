namespace Ecommerce.Comunes.Clases.Contratos.Estados
{
    public class EstadoContract
    {
        public int id_estado { get; set; }
        public string descripcion { get; set; } = string.Empty;
        public string tabla { get; set; } = string.Empty;
    }
}
