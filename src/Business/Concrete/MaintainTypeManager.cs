using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MaintainTypeManager : IMaintainTypeService
    {
        private readonly IMaintainTypeDal _maintainTypeDal;

        public MaintainTypeManager(IMaintainTypeDal maintainTypeDal)
        {
            _maintainTypeDal = maintainTypeDal;
        }

        public async Task AddMaintainType(MaintainType maintainType)
        {
            await _maintainTypeDal.AddAsync(maintainType);
        }

        public async Task<List<MaintainType>> GetMaintainAsync()
        {
            var result = await _maintainTypeDal.GetListAsync();
            return result.ToList();
        }

        public Task<MaintainType> GetMaintainTypeById()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateMaintainType(MaintainType maintainType)
        {
            await _maintainTypeDal.UpdateAsync(maintainType);
        }
    }
}
