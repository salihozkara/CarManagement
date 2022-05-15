using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class EfCarTypeDal : EfRepositoryBase<CarType, CarContext>, ICarTypeDal
{
    public EfCarTypeDal(CarContext context) : base(context)
    {
    }
}
