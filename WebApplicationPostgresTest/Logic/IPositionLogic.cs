using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationPostgresTest.ViewModel;

namespace WebApplicationPostgresTest.Logic
{
    public interface IPositionLogic
    {
        Task<bool> Add(PositionModel model);
        Task<IList<PositionModel>> GetAll();
    }
}
