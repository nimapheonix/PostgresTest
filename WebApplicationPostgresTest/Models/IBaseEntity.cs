using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationPostgresTest.Models
{
    public interface IBaseEntity
    {
        [Key]
        [MaxLength(36)]
        string Id { get; set; }
    }
}
