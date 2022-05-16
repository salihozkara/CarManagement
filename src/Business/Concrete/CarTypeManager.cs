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
    public class CarTypeManager : ICarTypeService
    {
        private readonly ICarTypeDal _carTypeDal;
        public CarTypeManager(ICarTypeDal carTypeDal)
        {
            _carTypeDal = carTypeDal;
        }

        public async Task AddCarTypeAsync(CarType carType)
        {
            await _carTypeDal.AddAsync(carType);
        }

        public async Task<List<CarType>> GetCarTypeAsync()
        {
            var result = await _carTypeDal.GetListAsync();
            return result.ToList();
        }

        public Task<CarType> GetCarTypeByIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateCarTypeAsync(CarType carType)
        {
            await _carTypeDal.UpdateAsync(carType);
        }
    }
}
