using EcommerceAPI.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Infraestructura.Repositorios.Clientes
{
    public interface IClientesRepository
    {
        /// <summary>
        /// Obtiene los registros de los clientes
        /// </summary>
        /// <returns>Lista de clientes de la base de datos</returns>
        List<ClienteEntity> GetAll();

        /// <summary>
        /// Obtiene un cliente por su ID
        /// </summary>
        /// <param name="id">parametro de consulta</param>
        /// <returns>El cliente de la base de datos si lo encuentra</returns>
        ClienteEntity Get(int id);

        /// <summary>
        /// Metodo para insertar nuevos clientes a la base de datos
        /// </summary>
        /// <param name="entidad">Objeto con los datos del cliente a insertar</param>
        /// <returns>El cliente que inserto</returns>
        ClienteEntity Insert(ClienteEntity entidad);

        /// <summary>
        /// Metodo para actualizar un registro de un cliente en la base datos
        /// </summary>
        /// <param name="entidad">Los datos del cliente actualizar</param>
        /// <returns>Cliente actualizado</returns>
        ClienteEntity Update(ClienteEntity entidad);

        /// <summary>
        /// Metodo para eliminar un cliente de la base de datos
        /// </summary>
        /// <param name="entidad">Datos del cliente</param>
        void Delete(ClienteEntity entidad);


        /// <summary>
        /// MEtodo usado para encontrar un usuario basado en su email
        /// </summary>
        /// <param name="email">Email ingresado por el usuario</param>
        /// <returns>Datos del cliente encontrado</returns>
        ClienteEntity FindByEmail(string email);
    }
}
