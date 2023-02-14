using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interface
{
    public interface IPersonService
    {
        public Task<List<PersonDTO>> GetAllAsync();
        public Task<PersonDTO> GetByIdAsync(int id);
        public Task<PersonDTO> AddAsync(string fName, string lName,string tz, DateTime birthDate, eStatusDTO status, eHMODTO hmo);
        public Task<PersonDTO> UpdateAsync(PersonDTO obj);
        public Task DeletAsync(int id);
        public Task<PersonDTO> GetByTzAsync(string tz);

    }
}
