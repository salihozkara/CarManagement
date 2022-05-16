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
    public class TransactionManager : ITransactionService
    {
        private readonly ITransactionDal _transactionDal;

        public TransactionManager(ITransactionDal transactionDal)
        {
            _transactionDal = transactionDal;
        }

        public async Task AddTransactionAsync(Transaction transaction)
        {
            await _transactionDal.AddAsync(transaction);
        }

        public async Task<List<Transaction>> GetTransactionAsync()
        {
            var result = await _transactionDal.GetListAsync();
            return result.ToList();
        }
    }
}
