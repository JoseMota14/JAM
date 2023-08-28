using JamServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Domain.Interfaces
{
    public interface IClothesRepository
    {
        Task<IEnumerable<Clothes>> GetClothes();
        Task<Clothes> GetById(int? id);

        Task<Clothes> Create(Clothes entity);
        Task<Clothes> Update(Clothes entity);
        Task<Clothes> Remove(Clothes entity);
    }
}
