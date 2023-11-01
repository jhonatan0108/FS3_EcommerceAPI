namespace EcommerceAPI.Comunes.Clases.Contratos.Categorias
{
    public class CategoriaContract
    {
        public int id_categoria { get; set; }
        public int nombre { get; set; }
        public int descripcion { get; set; }
        public int categoria_padre { get; set; }
    }
}
