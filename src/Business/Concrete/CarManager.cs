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
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public async Task AddCarAsync(Car car)
        {
            await _carDal.AddAsync(car);
        }

        public async Task<List<Car>> GetCarAsync()
        {
            var result = await _carDal.GetListAsync();
            return result.ToList();
        }

        public Task<Car> GetCarByIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateCarAsync(Car car)
        {
            await _carDal.UpdateAsync(car);
        }
    }
}
