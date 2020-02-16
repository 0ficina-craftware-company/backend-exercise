using Oficina.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Models
{
    public class Company : IEntity
    {
        [Required]
        [Key]
        public Guid Guid { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
