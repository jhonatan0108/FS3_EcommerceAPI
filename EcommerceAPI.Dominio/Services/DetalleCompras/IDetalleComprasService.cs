using EcommerceAPI.Comunes.Clases.Contratos.Clientes;
using EcommerceAPI.Comunes.Clases.Contratos.DetalleCompras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAPI.Dominio.Services.DetalleCompras
{
    public interface IDetalleComprasService
    {
        List<DetalleCompraContract> GetAll();

        DetalleCompraContract Get(int id);

        DetalleCompraContract Insert(DetalleCompraContract detalleCompra);

        DetalleCompraContract Update(DetalleCompraContract detalleCompra);

        void Delete(int id);
    }
}
