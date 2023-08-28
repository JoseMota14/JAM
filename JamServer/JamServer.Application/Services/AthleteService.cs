using AutoMapper;
using JamServer.Application.Athletes.Commands;
using JamServer.Application.Athletes.Queries;
using JamServer.Application.DTOs;
using JamServer.Application.Interfaces;
using JamServer.Domain.Entities;
using JamServer.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Application.Services
{
    public class AthleteService : IAthleteService
    {
        private IMediator _mediator;
        private readonly IMapper _mapper;
        public AthleteService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AthleteDTO>> GetAthletes()
        {
            var athleteQuery = new GetAthletesQuery();

            if(athleteQuery == null)
            {
                throw new Exception("Cant be null");
            }

            var result = await _mediator.Send(athleteQuery);
            return _mapper.Map<IEnumerable<AthleteDTO>>(result);
        }

        public async Task<AthleteDTO> GetById(int? id)
        {
            var athleteQuery = new GetAthleteByIdQuery(id.Value);

            if (athleteQuery == null)
            {
                throw new Exception("Cant be null");
            }
            var result = await _mediator.Send(athleteQuery);
            return _mapper.Map<AthleteDTO>(result);
        }

        public async Task Add(AthleteDTO athleteDTO)
        {
            var athleteCommand = _mapper.Map<AthleteCreateCommand>(athleteDTO);
            await _mediator.Send(athleteCommand);
        }

        public async Task Update(AthleteDTO athleteDTO)
        {
            var athleteCommand = _mapper.Map<AthleteUpdateCommand>(athleteDTO);
            await _mediator.Send(athleteCommand);
        }

        public async Task Remove(int? id)
        {
            var athleteQuery = new AthleteRemoveCommand(id.Value);
            if (athleteQuery == null)
            {
                throw new Exception("Cant be null");
            }
             await _mediator.Send(athleteQuery);
        }

    }
}
