using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMaintainService
    {
        Task<List<Maintain>> GetMaintainAsync();

        Task AddMaintainAsync(Maintain maintain);

        Task UpdateMaintainAsync(Maintain maintain);

        Task<Maintain> GetMaintainByIdAsync();

    }
}
