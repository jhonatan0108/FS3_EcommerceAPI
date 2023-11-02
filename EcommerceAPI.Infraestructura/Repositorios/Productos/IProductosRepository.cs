using EcommerceAPI.Infraestructura.Database.Entidades;
namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public interface IProductosRepository
    {
        /// <summary>
        /// Obtiene los registros de los clientes
        /// </summary>
        /// <returns>Lista de clientes de la base de datos</returns>
        List<ProductoEntity> GetAll();


        List<ProductoEntity> GetProductosPorFechas();

        /// <summary>
        /// Obtiene un cliente por su ID
        /// </summary>
        /// <param name="id">parametro de consulta</param>
        /// <returns>El cliente de la base de datos si lo encuentra</returns>
        ProductoEntity Get(int id);

        /// <summary>
        /// Metodo para insertar nuevos clientes a la base de datos
        /// </summary>
        /// <param name="entidad">Objeto con los datos del cliente a insertar</param>
        /// <returns>El cliente que inserto</returns>
        ProductoEntity Insert(ProductoEntity entidad);

        /// <summary>
        /// Metodo para actualizar un registro de un cliente en la base datos
        /// </summary>
        /// <param name="entidad">Los datos del cliente actualizar</param>
        /// <returns>Cliente actualizado</returns>
        ProductoEntity Update(ProductoEntity entidad);

        /// <summary>
        /// Metodo para eliminar un cliente de la base de datos
        /// </summary>
        /// <param name="entidad">Datos del cliente</param>
        void Delete(ProductoEntity entidad);
    }
}
