using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ICarTypeDal: IAsyncRepository<CarType> { }
