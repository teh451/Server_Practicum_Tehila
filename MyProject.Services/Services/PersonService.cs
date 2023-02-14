using MyProject.Common.DTOs;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Entities;
using MyProject.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace MyProject.Services.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _PersonRepository;
        private readonly IMapper _mapper;
        public PersonService(IPersonRepository personService, IMapper mapper)
        {
            _PersonRepository = personService;
            _mapper = mapper;
        }
        public async Task<PersonDTO> AddAsync(string fName, string lName,string tz, DateTime birthDate, eStatusDTO status, eHMODTO hmo)
        {
            var statusPer=_mapper.Map<eStatus>(status);
            var hmoPer=_mapper.Map<eHMO>(hmo);
            return _mapper.Map<PersonDTO>(await _PersonRepository.AddAsync(fName,lName,tz,birthDate, statusPer,hmoPer));
        }

        public async Task DeletAsync(int id)
        {
            await _PersonRepository.DeletAsync(id);
        }

        public async Task<List<PersonDTO>> GetAllAsync()
        {
            return _mapper.Map<List<PersonDTO>>(await _PersonRepository.GetAllAsync());
        }

        public async Task<PersonDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<PersonDTO>(await _PersonRepository.GetByIdAsync(id));
        }

        public async Task<PersonDTO> GetByTzAsync(string tz)
        {
            var listPerson =await GetAllAsync();
            return listPerson.Find(p => p.Tz == tz);
        }

        public async Task<PersonDTO> UpdateAsync(PersonDTO obj)
        {
            Person person = _mapper.Map<Person>(obj);
            return _mapper.Map<PersonDTO>(await _PersonRepository.UpdateAsync(person));
        }
    }
}
