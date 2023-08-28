using JamServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Domain.Interfaces
{
    public interface IAthleteRepository
    {
        Task<IEnumerable<Athlete>> GetAthletes();
        Task<Athlete> GetById(int? id);

        Task<Athlete> Create(Athlete entity);
        Task<Athlete> Update(Athlete entity);
        Task<Athlete> Remove(Athlete entity);

        Task<Athlete> GetAthleteClothes(int? id);
    }
}
