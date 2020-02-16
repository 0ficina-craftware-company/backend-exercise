using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oficina.Data;

namespace Oficina.Base.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public BaseController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(Guid id)
        {
            var company = await repository.Get(id);
            if (company == null)
            {
                return NotFound();
            }
            return company;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, TEntity company)
        {
            if (id != company.Guid)
            {
                return BadRequest();
            }

            await repository.Update(company);
            return Ok();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity company)
        {
            await repository.Add(company);
            return CreatedAtAction("Get", new { id = company.Guid }, company);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(Guid id)
        {
            var movie = await repository.Delete(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }

        //// GET: api/[controller]/5/6
        [HttpGet("{page}/{pageSize}")]
        public async Task<ActionResult<KeyValuePair<int, IEnumerable<TEntity>>>> Get(int page = 0, int pageSize = 5)
        {
            int total = await repository.TotalCount();
            var list = await repository.FindPaged(page, pageSize);

            if (list == null)
            {
                return NotFound();
            }

            return Ok(new KeyValuePair<int, IEnumerable<TEntity>>(total, list));
        }
    }
}