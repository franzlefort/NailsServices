using System;
using System.Linq;
using System.Threading.Tasks;
using AdministrationService.Database.Entities;
using AdministrationService.Database.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AdministrationService.Controllers
{
    [Route("api/[controller]/{action}")]
    public class EmployeeController : ControllerBase
    {
        private readonly IDbRepository _dbRepository;
        
        public EmployeeController(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }
        
        [HttpGet]
        public Employee Get(Guid id)
        {
            var employee = _dbRepository.Get<Employee>(x => x.Id == id).FirstOrDefault();

            return employee;
        }

        [HttpPost]
        public async Task<Guid> Add([FromBody] Employee employee)
        {
            var newId = await _dbRepository.Add(employee);
            await _dbRepository.SaveChangesAsync();

            return newId;
        }

        [HttpDelete]
        public async Task Delete(Guid id)
        {
            await _dbRepository.Delete<Employee>(id);
            await _dbRepository.SaveChangesAsync();
        }
    }
}