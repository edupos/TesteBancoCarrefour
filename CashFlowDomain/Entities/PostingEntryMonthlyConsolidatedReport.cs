using CashFlow.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Domain.Entities
{
    public class PostingEntryMonthlyConsolidatedReport
    {
        public EnumOperationType OperationType { get; private set; }
        public EnumOperationCurrency OperationCurrency { get; private set; }
        public decimal TotalMonth { get; private set; }
        public int OperationMonth { get; private set; }


        public PostingEntryMonthlyConsolidatedReport(EnumOperationType operationType, EnumOperationCurrency operationCurrency,
                decimal totalMonth, int operationMonth) 
        {
            OperationType = operationType;
            OperationCurrency = operationCurrency;
            TotalMonth = totalMonth;
            OperationMonth = operationMonth;
        }
    }
}
