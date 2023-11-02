namespace EcommerceAPI.Comunes.Clases.Contratos.Productos;

public class ProductoContract
{
    public int id_producto { get; set; }
    public string descripcion { get; set; }
    public double valor { get; set; }
    public string? imagen { get; set; }
    public int id_estado { get; set; }
    public int stock { get; set; }
}
