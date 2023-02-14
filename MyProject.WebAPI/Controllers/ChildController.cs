using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Services.Interface;
using MyProject.WebAPI.Models;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;
        public ChildController(IChildService childService)
        {
            _childService = childService;
        }
        [HttpGet]
        public async Task<IEnumerable<ChildDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildDTO> GetById(int id)
        {
            return await _childService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task Post([FromBody] ChildModel child) //add
        {
            await _childService.AddAsync(child.Name,child.BirthDate,child.Tz,child.ParentId);
        }
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] ChildModel child)
        {
            await _childService.UpdateAsync(new ChildDTO {Id=id, Name = child.Name, BirthDate = child.BirthDate,Tz=child.Tz, ParentId=child.ParentId});
        }
        [HttpDelete]
        public async Task DeleteAsync(int id)
        {
            await _childService.DeletAsync(id);
        }
    }


}
