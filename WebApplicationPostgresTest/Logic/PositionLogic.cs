using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationPostgresTest.Mapper;
using WebApplicationPostgresTest.Models;
using WebApplicationPostgresTest.Repository;
using WebApplicationPostgresTest.ViewModel;

namespace WebApplicationPostgresTest.Logic
{
    public class PositionLogic : IPositionLogic
    {
        private readonly IPositionRepository positionRepository;
        public PositionLogic(IPositionRepository positionRepository)
        {
            this.positionRepository = positionRepository;
        }
        public async Task<bool> Add(PositionModel model)
        {
            await positionRepository.Add(model.ToEntity());
            await positionRepository.Commit();
            return true;
        }
        public async Task<IList<PositionModel>> GetAll()
        {
            var positions = await positionRepository.GetAll();
            return positions.Select(i => i.ToModel()).ToList();
        }
    }
}
