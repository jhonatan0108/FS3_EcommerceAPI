using EcommerceAPI.Infraestructura.Database.Entidades;


namespace EcommerceAPI.Infraestructura.Repositorios.Productos
{
    public interface IProductosRepository
    {
        /// <summary>
        /// Obtiene los registros de los productos
        /// </summary>
        /// <returns>Lista de productos de la base de datos</returns>
        List<ProductoEntity> GetAll();

        /// <summary>
        /// Obtiene un productos por su ID
        /// </summary>
        /// <param name="id">parametro de consulta</param>
        /// <returns>El productos de la base de datos si lo encuentra</returns>
        ProductoEntity Get(int id);

        /// <summary>
        /// Metodo para insertar nuevos productos a la base de datos
        /// </summary>
        /// <param name="entidad">Objeto con los datos del productos a insertar</param>
        /// <returns>El productos que inserto</returns>
        ProductoEntity Insert(ProductoEntity entidad);

        /// <summary>
        /// Metodo para actualizar un registro de un productos en la base datos
        /// </summary>
        /// <param name="entidad">Los datos del productos actualizar</param>
        /// <returns>productos actualizado</returns>
        ProductoEntity Update(ProductoEntity entidad);

        /// <summary>
        /// Metodo para eliminar un productos de la base de datos
        /// </summary>
        /// <param name="entidad">Datos del productos</param>
        void Delete(ProductoEntity entidad);
    }
}
