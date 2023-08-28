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
    public class ClothesRepository : IClothesRepository
    {
        ApplicationDbContext _context;
        public ClothesRepository(ApplicationDbContext applicationDBContext)
        {
            _context = applicationDBContext;
        }

        public async Task<Clothes> Create(Clothes entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Clothes> GetById(int? id)
        {
            return await _context.Clothes.FindAsync(id);
        }

        public async Task<IEnumerable<Clothes>> GetClothes()
        {
            return await _context.Clothes.ToListAsync();
        }

        public async Task<Clothes> Remove(Clothes entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Clothes> Update(Clothes entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity; 
        }
    }
}
