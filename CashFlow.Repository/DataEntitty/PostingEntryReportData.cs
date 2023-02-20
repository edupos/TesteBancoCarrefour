using CashFlow.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Repository.DataEntitty
{
    public class PostingEntryReportData
    {
        public EnumOperationType OperationType { get; set; }
        public EnumOperationCurrency OperationCurrency { get; set; }
        public decimal TotalMonth { get; set; }
        public int OperationMonth { get; set; }
    }
}
