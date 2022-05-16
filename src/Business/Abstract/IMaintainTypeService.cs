using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMaintainTypeService
    {
        Task<List<MaintainType>> GetMaintainAsync();

        Task AddMaintainType(MaintainType maintainType);

        Task UpdateMaintainType(MaintainType maintainType);

        Task <MaintainType> GetMaintainTypeById();
    }
}
