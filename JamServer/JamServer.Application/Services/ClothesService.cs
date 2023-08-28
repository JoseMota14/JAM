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
    public class ClothesService : IClothesService
    {
        private IClothesRepository _clothesRepository;
        private readonly IMapper _mapper;
        public ClothesService(IClothesRepository clothesRepository, IMapper mapper)
        {
            _clothesRepository = clothesRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClothesDTO>> GetClothes()
        {
            var clothes = await _clothesRepository.GetClothes();
            return _mapper.Map<IEnumerable<ClothesDTO>>(clothes);
        }

        public async Task<ClothesDTO> GetById(int? id)
        {
            var clothes = await _clothesRepository.GetById(id);
            return _mapper.Map<ClothesDTO>(clothes);
        }

        public async Task Add(ClothesDTO clothesDTO)
        {
            var clothes = _mapper.Map<Clothes>(clothesDTO);
            await _clothesRepository.Create(clothes);
        }

        public async Task Update(ClothesDTO clothesDTO)
        {
            var clothes = _mapper.Map<Clothes>(clothesDTO);
            await _clothesRepository.Update(clothes);
        }

        public async Task Remove(int? id)
        {
            var clothes = _clothesRepository.GetById(id).Result;
            await _clothesRepository.Create(clothes);
        }
    }
}
