using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class EfMaintainDal : EfRepositoryBase<Maintain, CarContext>, IMaintainDal
{
    public EfMaintainDal(CarContext context) : base(context)
    {
    }
}
