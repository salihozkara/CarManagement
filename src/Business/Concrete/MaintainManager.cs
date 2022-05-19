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
    public class MaintainManager : IMaintainService
    {
        private readonly IMaintainDal _maintainDal;

        public MaintainManager(IMaintainDal maintainDal)
        {
            _maintainDal = maintainDal;
        }

        public async Task AddMaintainAsync(Maintain maintain)
        {
            await _maintainDal.AddAsync(maintain);
        }

        public async Task<List<Maintain>> GetMaintainAsync()
        {
            var result = await _maintainDal.GetListAsync();
            return result.ToList();
        }
        public async Task<List<Maintain>> GetMaintainsByMaintainTypeIdAsync(int maintainTypeId)
        {
            var result = await _maintainDal.GetListAsync(m => m.MaintainTypeId == maintainTypeId);
            return result.ToList();
        }
        public async Task<Maintain> GetMaintainByIdAsync(int id)
        {
            return await _maintainDal.GetAsync(x => x.Id == id);
        }

        public async Task UpdateMaintainAsync(Maintain maintain)
        {
            await _maintainDal.UpdateAsync(maintain);
        }
    }
}
