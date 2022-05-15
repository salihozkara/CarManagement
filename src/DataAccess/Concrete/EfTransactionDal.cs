using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class EfTransactionDal : EfRepositoryBase<Transaction, CarContext>, ITransactionDal
{
    public EfTransactionDal(CarContext context) : base(context)
    {
    }
}