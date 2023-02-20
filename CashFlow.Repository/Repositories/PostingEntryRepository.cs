using CashFlow.Domain.Entities;
using CashFlow.Domain.Interfaces.Repositories;
using CashFlow.Repository.Context;
using CashFlow.Repository.DataEntitty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Repository.Repositories
{
    public class PostingEntryRepository : EfCoreRepository<PostingEntry, CashFlowContext>, IPostingEntryRepository
    {
        private readonly CashFlowContext _context;
        public PostingEntryRepository(CashFlowContext context) : base(context)
        {
            _context = context;
        }

        public List<PostingEntryMonthlyConsolidatedReport> GetMonthlyConsolidatedReport()
        {
            var report = _context.PostingEntries
                .GroupBy(e => new { e.OperationDate.Month, e.OperationType, e.OperationCurrency })
                .Select(s => new PostingEntryReportData()
                {
                    OperationType = s.First().OperationType,
                    OperationCurrency = s.First().OperationCurrency,
                    OperationMonth = s.First().OperationDate.Month,
                    TotalMonth = s.Sum(m => m.OperationValue)
                }).ToList();

            List<PostingEntryMonthlyConsolidatedReport> result = new List<PostingEntryMonthlyConsolidatedReport>();
            if(report != null)
            {
                foreach(var item in report)
                {
                    result.Add(new PostingEntryMonthlyConsolidatedReport(
                          item.OperationType, item.OperationCurrency, item.TotalMonth, item.OperationMonth
                        ));
                }
            }

            return result;
        }

    }
}
