using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationPostgresTest.Models
{
    public class BaseEntity : IBaseEntity
    {
        public string Id { get ; set ; }
    }
}
