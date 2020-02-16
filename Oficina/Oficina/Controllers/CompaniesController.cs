using Microsoft.AspNetCore.Mvc;
using Oficina.Base.Controllers;
using Oficina.Data.EFCore;
using Oficina.Models;

namespace Oficina.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : BaseController<Company, EfCoreCompanyRepository>
    {
        public CompaniesController(EfCoreCompanyRepository repository) : base(repository)
        {

        }
    }
}
