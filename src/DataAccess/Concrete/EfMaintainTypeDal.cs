using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class EfMaintainTypeDal : EfRepositoryBase<MaintainType, CarContext>, IMaintainTypeDal
{
    public EfMaintainTypeDal(CarContext context) : base(context)
    {
    }
}
