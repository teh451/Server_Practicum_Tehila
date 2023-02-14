using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IContex _contex;
        public PersonRepository(IContex contex)
        {
            _contex= contex;
        }
        public async Task<Person> AddAsync( string fName, string lName,string tz, DateTime birthDate, eStatus status, eHMO hmo)
        {
            var person = new Person { FirstName = fName, LastName = lName, Tz = tz, BirthDate = birthDate, status = status, HMO = hmo };
            _contex.Persons.Add(person);
            await _contex.SaveChangesAsync();
            return person;
        }

        public async Task DeletAsync(int id)
        {
            var person =await _contex.Persons.FindAsync(id);
            _contex.Persons.Remove(person);
             await  _contex.SaveChangesAsync();
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _contex.Persons.ToListAsync();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _contex.Persons.FindAsync(id);
        }

        public async Task<Person> UpdateAsync(Person obj)
        {
           var p=_contex.Persons.Update(obj);    
            await _contex.SaveChangesAsync();
            return p.Entity;
        }
    }
}
