using System;
using System.Linq;
using System.Threading.Tasks;
using AdministrationService.Database.Entities;
using AdministrationService.Database.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AdministrationService.Controllers
{
    [Route("api/[controller]/{action}")]
    public class PostController : ControllerBase
    {
        private readonly IDbRepository _dbRepository;
        
        public PostController(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }
        
        [HttpGet]
        public Post Get(Guid id)
        {
            var post = _dbRepository.Get<Post>(x => x.Id == id).FirstOrDefault();

            return post;
        }

        [HttpPost]
        public async Task<Guid> Add([FromBody] Post post)
        {
            var newPostId = await _dbRepository.Add(post);
            await _dbRepository.SaveChangesAsync();

            return newPostId;
        }

        [HttpDelete]
        public async Task Delete(Guid id)
        {
            await _dbRepository.Delete<Post>(id);
            await _dbRepository.SaveChangesAsync();
        }
    }
}