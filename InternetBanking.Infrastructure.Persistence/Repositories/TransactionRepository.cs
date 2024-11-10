using InternetBanking.Core.Application.Interfaces.Repositories;
using InternetBanking.Core.Domain.Entities;
using InternetBanking.Infrastructure.Persistence.Contexts;

namespace InternetBanking.Infrastructure.Persistence.Repositories
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionsRepository
    {
        private readonly AppDbContext _dbContext;
        public TransactionRepository(AppDbContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}
