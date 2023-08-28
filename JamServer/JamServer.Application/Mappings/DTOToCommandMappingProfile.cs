using AutoMapper;
using JamServer.Application.Athletes.Commands;
using JamServer.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<AthleteDTO, AthleteCreateCommand>();
            CreateMap<AthleteDTO, AthleteUpdateCommand>();
        }
    }
}
