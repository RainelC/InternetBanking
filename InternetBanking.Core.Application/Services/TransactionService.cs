using AutoMapper;
using InternetBanking.Core.Application.Interfaces.Repositories;
using InternetBanking.Core.Application.Interfaces.Services;
using InternetBanking.Core.Application.ViewModels.Transaction;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Application.Services
{
    public class TransactionService : GenericService<SaveTransactionViewModel, TransactionViewModel, Transaction>, ITransactionService
    {
        private readonly ITransactionsRepository _transactionsRepository;
        private readonly IMapper _mapper;
        public TransactionService(ITransactionsRepository repository, IMapper mapper) : base(repository, mapper) 
        {
            _transactionsRepository = repository;
            _mapper = mapper;
        }
    }
}
