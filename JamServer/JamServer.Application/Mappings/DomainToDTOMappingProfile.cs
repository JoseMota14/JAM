using AutoMapper;
using JamServer.Application.DTOs;
using JamServer.Domain.Entities;

namespace JamServer.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Athlete, AthleteDTO>().ReverseMap();
            CreateMap<Clothes, ClothesDTO>().ReverseMap();
        }
    }
}
