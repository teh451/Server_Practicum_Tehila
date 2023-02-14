using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class ChildService:IChildService
    {
        private readonly IChildRepository _ChildRepository;
        private readonly IMapper _mapper;
        public ChildService(IChildRepository childService, IMapper mapper)
        {
            _ChildRepository = childService;
            _mapper = mapper;
        }
        public async Task<ChildDTO> AddAsync(string name, DateTime birthDate,string tz, int idParent)
        {
            return _mapper.Map<ChildDTO>(await _ChildRepository.AddAsync(name, birthDate,tz, idParent));
        }

        public async Task DeletAsync(int id)
        {
            await _ChildRepository.DeletAsync(id);
        }

        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _ChildRepository.GetAllAsync());
        }

        public async Task<ChildDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<ChildDTO>(await _ChildRepository.GetByIdAsync(id));
        }

        public async Task<ChildDTO> UpdateAsync(ChildDTO obj)
        {
            Child person = _mapper.Map<Child>(obj);
            return _mapper.Map<ChildDTO>(await _ChildRepository.UpdateAsync(person));
        }
    }
}
