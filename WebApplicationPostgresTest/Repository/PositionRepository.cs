
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationPostgresTest.Data;
using WebApplicationPostgresTest.Models;

namespace WebApplicationPostgresTest.Repository
{
    public class PositionRepository : BaseRepository<Position>, IPositionRepository
    {
        public PositionRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
