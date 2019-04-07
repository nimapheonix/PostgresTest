using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationPostgresTest.Data;
using WebApplicationPostgresTest.Models;

namespace WebApplicationPostgresTest.Repository
{
    public class DeviceRepository : BaseRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
