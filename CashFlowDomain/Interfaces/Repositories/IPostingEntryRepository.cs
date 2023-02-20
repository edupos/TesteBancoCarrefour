using CashFlow.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Domain.Interfaces.Repositories
{
    public interface IPostingEntryRepository : IRepository<PostingEntry>
    {
        List<PostingEntryMonthlyConsolidatedReport> GetMonthlyConsolidatedReport();
    }
}
