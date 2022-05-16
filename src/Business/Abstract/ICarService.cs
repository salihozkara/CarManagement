using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface ICarService
    {
        Task <List<Car>> GetCarAsync();

        Task AddCarAsync(Car car);

        Task UpdateCarAsync(Car car);

        Task <Car> GetCarByIdAsync();

    }
}
