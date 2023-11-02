using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Comunes.Clases.Contratos.Estados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.Estados
{
    public interface IEstadosService
    {
        List<EstadoContract> GetAll();

        EstadoContract Get(int id);

        EstadoContract Insert(EstadoContract cliente);

        EstadoContract Update(EstadoContract cliente);

        void Delete(int id);
    }
}
