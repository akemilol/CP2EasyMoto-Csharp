using AutoMapper;
using EasyMoto.Application.DTOs.Response;
using EasyMoto.Domain.Entities;

namespace EasyMoto.Application.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Filial, CreatedFilialResponse>();
            CreateMap<Moto, CreatedMotoResponse>();
        }
    }
}
