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
    public class ChildRepository : IChildRepository
    {
        private readonly IContex _contex;
        public ChildRepository(IContex contex)
        {
            _contex = contex;
        }
        public async Task<Child> AddAsync(string name, DateTime date,string tz, int idParent)
        {
            var child = new Child { Name = name, BirthDate = date,Tz=tz, ParentId = idParent};
            _contex.Children.Add(child);
            await _contex.SaveChangesAsync();
            return child;
        }

        public async Task DeletAsync(int id)
        {
            var child =await _contex.Children.FindAsync(id);
            _contex.Children.Remove(child);
            await _contex.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _contex.Children.Include(c=>c.Parent).ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await _contex.Children.Include(c => c.Parent).FirstOrDefaultAsync(child => child.Id == id);
        }

        public async Task<Child> UpdateAsync(Child obj)
        {
            var c = _contex.Children.Update(obj);
            await _contex.SaveChangesAsync();
            return c.Entity;
        }
    }
}
