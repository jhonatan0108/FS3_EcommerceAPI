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
        /// Obtiene un producto por su ID
        /// </summary>
        /// <param name="id">parametro de consulta</param>
        /// <returns>El producto de la base de datos si lo encuentra</returns>
        ProductoEntity Get(int id);

        /// <summary>
        /// Metodo para insertar nuevos productos a la base de datos
        /// </summary>
        /// <param name="entidad">Objeto con los datos del producto a insertar</param>
        /// <returns>El el producto que inserto</returns>
        ProductoEntity Insert(ProductoEntity entidad);

        /// <summary>
        /// Metodo para actualizar un registro de un pruducto en la base datos
        /// </summary>
        /// <param name="entidad">Los datos del producto actualizar</param>
        /// <returns>Producto actualizado</returns>
        ProductoEntity Update(ProductoEntity entidad);

        /// <summary>
        /// Metodo para eliminar un producto de la base de datos
        /// </summary>
        /// <param name="entidad">Datos del producto</param>
        void Delete(ProductoEntity entidad);
    }
}

