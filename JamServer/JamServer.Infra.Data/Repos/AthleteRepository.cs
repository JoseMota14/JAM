using JamServer.Domain.Entities;
using JamServer.Domain.Interfaces;
using JamServer.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Infra.Data.Repos
{
    public class AthleteRepository : IAthleteRepository
    {
        ApplicationDbContext _context;
        public AthleteRepository(ApplicationDbContext applicationDBContext)
        {
            _context = applicationDBContext;
        }
        public async Task<Athlete> Create(Athlete entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Athlete> GetAthleteClothes(int? id)
        {
            return await _context.Athletes.Include(c => c.Clothes).SingleOrDefaultAsync(a => a.Id == id);  
        }

        public async Task<IEnumerable<Athlete>> GetAthletes()
        {
            return await _context.Athletes.ToListAsync();
        }

        public async Task<Athlete> GetById(int? id)
        {
            return await _context.Athletes.FindAsync(id);
        }

        public async Task<Athlete> Remove(Athlete entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Athlete> Update(Athlete entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
