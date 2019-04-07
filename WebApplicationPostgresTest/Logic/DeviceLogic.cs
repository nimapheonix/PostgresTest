using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationPostgresTest.Mapper;
using WebApplicationPostgresTest.Repository;
using WebApplicationPostgresTest.ViewModel;

namespace WebApplicationPostgresTest.Logic
{
    public class DeviceLogic : IDeviceLogic
    {
        private readonly IDeviceRepository deviceRepository;
        public DeviceLogic(IDeviceRepository deviceRepository)
        {
            this.deviceRepository = deviceRepository;
        }
        public async Task<bool> Add(DeviceModel model)
        {
            await deviceRepository.Add(model.ToEntity());
            await deviceRepository.Commit();
            return true;
        }
        public async Task<IList<DeviceModel>> GetAll()
        {
            var devices = await deviceRepository.GetAll();
            return devices.Select(i => i.ToModel()).ToList();
        }
    }
}
