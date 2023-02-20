using CashFlow.Domain.Entities;
using CashFlow.Domain.Interfaces.Repositories;
using CashFlow.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Domain.Services
{
    public class PostingEntryService : Service<PostingEntry>, IPostingEntryService
    {
        private readonly IPostingEntryRepository _repository;
        public PostingEntryService(IPostingEntryRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public List<PostingEntryMonthlyConsolidatedReport> GetMonthlyConsolidatedReport()
        {
            return _repository.GetMonthlyConsolidatedReport();
        }

    }
}
