using AutoMapper;
using JamServer.Application.DTOs;
using JamServer.Application.Interfaces;
using JamServer.Domain.Entities;
using JamServer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Application.Services
{
    internal class AthleteService : IAthleteService
    {
        private IAthleteRepository _athleteRepository;
        private readonly IMapper _mapper;
        public AthleteService(IAthleteRepository athleteRepository, IMapper mapper)
        {
            _athleteRepository = athleteRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AthleteDTO>> GetAthletes()
        {
            var clothes = await _athleteRepository.GetAthletes();
            return _mapper.Map<IEnumerable<AthleteDTO>>(clothes);
        }

        public async Task<AthleteDTO> GetById(int? id)
        {
            var clothes = await _athleteRepository.GetById(id);
            return _mapper.Map<AthleteDTO>(clothes);
        }

        public async Task Add(AthleteDTO athleteDTO)
        {
            var athlete = _mapper.Map<Athlete>(athleteDTO);
            await _athleteRepository.Create(athlete);
        }

        public async Task Update(AthleteDTO athleteDTO)
        {
            var athlete = _mapper.Map<Athlete>(athleteDTO);
            await _athleteRepository.Update(athlete);
        }

        public async Task Remove(int? id)
        {
            var athlete = _athleteRepository.GetById(id).Result;
            await _athleteRepository.Create(athlete);
        }

        public async Task<AthleteDTO> GetAthleClothes(int? id)
        {
            var athlete = await _athleteRepository.GetAthleteClothes(id);
            return _mapper.Map<AthleteDTO>(athlete);
        }
    }
}
