using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdministrationService.Database.Entities;
using AdministrationService.Database.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AdministrationService.Controllers
{
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IDbRepository _dbRepository;
        
        public PostController(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }
        
        [HttpGet("GetAll")]
        public IQueryable<Post> GetAll()
        {
            var posts = _dbRepository.Get<Post>();

            return posts;
        }
        
        [HttpGet("Get")]
        public Post Get(Guid id)
        {
            var post = _dbRepository.Get<Post>(x => x.Id == id).FirstOrDefault();

            return post;
        }

        [HttpPost("Add")]
        public async Task<Guid> Add([FromBody] Post post)
        {
            var newId = await _dbRepository.Add(post);
            await _dbRepository.SaveChangesAsync();

            return newId;
        }

        [HttpDelete("Remove")]
        public async Task Delete(Guid id)
        {
            await _dbRepository.Delete<Post>(id);
            await _dbRepository.SaveChangesAsync();
        }
    }
}