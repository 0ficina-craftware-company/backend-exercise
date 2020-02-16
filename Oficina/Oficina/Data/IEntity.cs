using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Data
{
    public interface IEntity
    {
        Guid Guid { get; set; }
    }
}
