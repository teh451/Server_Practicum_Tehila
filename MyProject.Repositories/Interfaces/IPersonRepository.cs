using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        public Task<List<Person>> GetAllAsync();
        public Task<Person> GetByIdAsync(int id);
        public Task<Person> AddAsync(string fName,string lName,string tz,DateTime birthDate,eStatus status,eHMO hmo);
        public Task<Person> UpdateAsync(Person obj);
        public Task DeletAsync(int id);
    }
}
