using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Services.Interface;
using MyProject.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet]
        public async Task<IEnumerable<PersonDTO>> Get()
        {
            return await _personService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<PersonDTO> GetById(int id)
        {
            return await _personService.GetByIdAsync(id);
        }
        [HttpGet("tz/{tz}")]
        public async Task<PersonDTO> GetByTz(string tz)
        {
            return await _personService.GetByTzAsync(tz);
        }
        [HttpPost]
        public async Task Post([FromBody] PersonModel person) //add
        {
            await _personService.AddAsync(person.FirstName,person.LastName, person.Tz, person.BirthDate, (eStatusDTO)person.Status, (eHMODTO)person.HMO);
        }
        [HttpPut("{id}")]
        public async Task Put(int id,[FromBody] PersonModel person)
        {
            await _personService.UpdateAsync(new PersonDTO { Id = id, FirstName = person.FirstName, LastName = person.LastName,Tz=person.Tz, BirthDate = person.BirthDate,statusDTO= person.Status,HMODTO= person.HMO });
        }
        [HttpDelete]
        public async Task DeleteAsync(int id)
        {
            await _personService.DeletAsync(id);
        }
    }
}
