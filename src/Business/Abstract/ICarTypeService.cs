using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarTypeService
    {
        Task<List<CarType>> GetCarTypeAsync();

        Task AddCarTypeAsync(CarType carType);

        Task UpdateCarTypeAsync(CarType carType);

        Task<CarType> GetCarTypeByIdAsync();
    }
}
