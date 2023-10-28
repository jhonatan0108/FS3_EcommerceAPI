using AutoMapper;
using Ecommerce.Comunes.Clases.Contratos.Clientes;
using Ecommerce.Infraestructura.Database.Entidades;

namespace EcommerceAPI.Configuracion.Container
{
    public class PerfilAutoMapper : Profile
    {
        public PerfilAutoMapper()
        {
            CreateMap<ClienteEntity, ClienteContract>().ReverseMap();
        }
    }
}
