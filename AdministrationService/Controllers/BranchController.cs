using System;
using System.Linq;
using System.Threading.Tasks;
using AdministrationService.Database.Entities;
using AdministrationService.Database.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AdministrationService.Controllers
{
    [Route("api/[controller]")]
    public class BranchController : ControllerBase
    {
        private readonly IDbRepository _dbRepository;
        
        public BranchController(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }
        
        [HttpGet("GetAll")]
        public IQueryable<Branch> GetAll()
        {
            var branches = _dbRepository.Get<Branch>();

            return branches;
        }

        [HttpGet("Get")]
        public Branch Get(Guid id)
        {
            var branch = _dbRepository.Get<Branch>(x => x.Id == id).FirstOrDefault();

            return branch;
        }

        [HttpPost("Add")]
        public async Task<Guid> Add([FromBody] Branch employee)
        {
            var newId = await _dbRepository.Add(employee);
            await _dbRepository.SaveChangesAsync();

            return newId;
        }

        [HttpDelete("Remove")]
        public async Task Delete(Guid id)
        {
            await _dbRepository.Delete<Employee>(id);
            await _dbRepository.SaveChangesAsync();
        }
    }
}