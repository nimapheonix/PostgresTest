using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationPostgresTest.ViewModel;

namespace WebApplicationPostgresTest.Logic
{
    public interface IDeviceLogic
    {
        Task<bool> Add(DeviceModel model);
        Task<IList<DeviceModel>> GetAll();
    }
}
