using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace myDotNetTestApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly DataContext _context;
        public CompaniesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Company>>> Get(int pageNumber, int pageSize)
        {
            var pageCount = Math.Ceiling(_context.Companies.Count() / (float)pageSize);
            var Companies = await _context.Companies.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            var response = new CompanyResponse
            {
                Company = Companies,
                CurrentPage = pageNumber,
                Pages = (int)pageCount,
            };
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> Get(Guid id)
        {
            var Company = await _context.Companies.FindAsync(id);

            if (Company == null)
            {
                return NotFound("Company not found!");
            }
            return Ok(Company);
        }

        [HttpPost]
        public async Task<ActionResult<List<Company>>> AddCompany(Company company)
        {

            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<List<Company>>> UpdateCompany(Company request)
        {
            var Company = await _context.Companies.FindAsync(request.Id);

            if (Company == null)
            {
                return NotFound("Company not found!");
            }

            Company.Name = request.Name;
            Company.Url = request.Url;
            Company.Email = request.Email;

            _context.Companies.Update(Company);
            await _context.SaveChangesAsync();

            return Ok(Company);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Company>> Delete(Guid id)
        {
            var Company = await _context.Companies.FindAsync(id);

            if (Company == null)
            {
                return NotFound("Company not found!");
            }

           _context.Companies.Remove(Company);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
