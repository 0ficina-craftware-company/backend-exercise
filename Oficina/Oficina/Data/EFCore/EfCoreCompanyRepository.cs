using Oficina.Data.EFCore;
using Oficina.Models;

namespace Oficina.Data.EFCore
{
    public class EfCoreCompanyRepository : EfCoreRepository<Company, OficinaContext>
    {
        public EfCoreCompanyRepository(OficinaContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}