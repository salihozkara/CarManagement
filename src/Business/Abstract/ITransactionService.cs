using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITransactionService
    {
        Task<List<Transaction>> GetTransactionAsync();
        Task<List<Transaction>> GetTransactionByCarIdAsync(int carId);
        Task AddTransactionAsync(Transaction transaction);
    }
}
