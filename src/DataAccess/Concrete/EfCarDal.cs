using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;
public class EfCarDal : EfRepositoryBase<Car, CarContext>, ICarDal
{
    public EfCarDal(CarContext context) : base(context)
    {
    }
}
