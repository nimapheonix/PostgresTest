using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationPostgresTest.Models;
using WebApplicationPostgresTest.ViewModel;

namespace WebApplicationPostgresTest.Mapper
{
    public static class ModelMapper
    {
        public static Position ToEntity(this PositionModel model)
        {
            return new Position()
            {
                Id = Guid.NewGuid().ToString(),
                Accuracy = model.Accuracy,
                Address = model.Address,
                Altitude = model.Altitude,
                Attributes = model.Attributes,
                Course = model.Course,
                DeviceId = model.DeviceId,
                DeviceTime = model.DeviceTime,
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                Network = model.Network,
                Protocol = model.Protocol,
                Valid = true,
                Speed = model.Speed,
                Fixtime = DateTime.Now,
                ServerTime = DateTime.Now
            };
        }
        public static PositionModel ToModel(this Position entity)
        {
            return new PositionModel()
            {
                DeviceId = entity.DeviceId,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude,
                DeviceTime = entity.DeviceTime,
                ServerTime = entity.ServerTime
            };
        }
        public static Device ToEntity(this DeviceModel model)
        {
            return new Device()
            {
                Id = Guid.NewGuid().ToString(),
                Name = model.Name
            };
        }
        public static DeviceModel ToModel(this Device entity)
        {
            return new DeviceModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = entity.Name
            };  
        }

    }
}
