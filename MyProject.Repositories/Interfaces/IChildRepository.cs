using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IChildRepository
    {
        public Task<List<Child>> GetAllAsync();
        public Task<Child> GetByIdAsync(int id);
        public Task<Child> AddAsync(string name,DateTime date,string tz,int idParent);
        public Task<Child> UpdateAsync(Child obj);
        public Task DeletAsync(int id);
    }
}
