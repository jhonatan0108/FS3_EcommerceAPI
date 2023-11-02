using EcommerceAPI.Infraestructura.Database.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Infraestructura.Repositorios.Estados
{
    public interface IEstadosRepository
    {
        /// <summary>
        /// Obtiene los registros de los clientes
        /// </summary>
        /// <returns>Lista de clientes de la base de datos</returns>
        List<EstadoEntity> GetAll();

        /// <summary>
        /// Obtiene un cliente por su ID
        /// </summary>
        /// <param name="id">parametro de consulta</param>
        /// <returns>El cliente de la base de datos si lo encuentra</returns>
        EstadoEntity Get(int id);

        /// <summary>
        /// Metodo para insertar nuevos clientes a la base de datos
        /// </summary>
        /// <param name="entidad">Objeto con los datos del cliente a insertar</param>
        /// <returns>El cliente que inserto</returns>
        EstadoEntity Insert(EstadoEntity entidad);

        /// <summary>
        /// Metodo para actualizar un registro de un cliente en la base datos
        /// </summary>
        /// <param name="entidad">Los datos del cliente actualizar</param>
        /// <returns>Cliente actualizado</returns>
        EstadoEntity Update(EstadoEntity entidad);

        /// <summary>
        /// Metodo para eliminar un cliente de la base de datos
        /// </summary>
        /// <param name="entidad">Datos del cliente</param>
        void Delete(EstadoEntity entidad);
    }
}
