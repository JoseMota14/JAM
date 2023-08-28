using JamServer.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Application.Interfaces
{
    public interface IAthleteService
    {
        Task<IEnumerable<AthleteDTO>> GetAthletes();
        Task<AthleteDTO> GetById(int? id);
        Task<AthleteDTO> GetAthleClothes(int? id);
        Task Add(AthleteDTO athleteDTO);
        Task Update(AthleteDTO athleteDTO);
        Task Remove(int? id);
    }
}
