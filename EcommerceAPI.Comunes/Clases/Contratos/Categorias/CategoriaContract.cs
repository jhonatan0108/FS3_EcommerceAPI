namespace EcommerceAPI.Comunes.Clases.Contratos.Categorias
{
    public class CategoriaContract
    {
        public int id_categoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int? categoria_padre { get; set; }
    }
}
