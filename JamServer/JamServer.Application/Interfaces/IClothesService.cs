using JamServer.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Application.Interfaces
{
    public interface IClothesService
    {
        Task<IEnumerable<ClothesDTO>> GetClothes();
        Task<ClothesDTO> GetById(int? id);
        Task Add(ClothesDTO clothesDTO);
        Task Update(ClothesDTO clothesDTO);
        Task Remove(int? id);
    }
}
