using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Compra
{
    public interface IComprasRepository
    {
        /// <summary>
        /// Obtiene los registros de los Compras
        /// </summary>
        /// <returns>Lista de Compras de la base de datos</returns>
        List<CompraEntity> GetAll();

        /// <summary>
        /// Obtiene un Compra por su ID
        /// </summary>
        /// <param name="id">parametro de consulta</param>
        /// <returns>El Compra de la base de datos si lo encuentra</returns>
        CompraEntity Get(int id);

        /// <summary>
        /// Metodo para insertar nuevos Compras a la base de datos
        /// </summary>
        /// <param name="entidad">Objeto con los datos del Compra a insertar</param>
        /// <returns>El Compra que inserto</returns>
        CompraEntity Insert(CompraEntity entidad);

        /// <summary>
        /// Metodo para actualizar un registro de un Compra en la base datos
        /// </summary>
        /// <param name="entidad">Los datos del Compra actualizar</param>
        /// <returns>Compra actualizado</returns>
        CompraEntity Update(CompraEntity entidad);

        /// <summary>
        /// Metodo para eliminar un Compra de la base de datos
        /// </summary>
        /// <param name="entidad">Datos del Compra</param>
        void Delete(CompraEntity entidad);
    }
}
