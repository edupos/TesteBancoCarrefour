using CashFlow.Domain.Enum;
using CashFlow.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Domain.Entities
{
    public class PostingEntry : IEntityBase
    {
        public EnumOperationType OperationType { get; private set; }
        public EnumOperationCurrency OperationCurrency { get; private set; }
        public decimal OperationValue { get; private set; }
        public string Description { get; private set; }
        public string Observation { get; private set; }
        public DateTime OperationDate { get; private set; }
        public int Id { get; set; }

        public PostingEntry(EnumOperationType operationType, EnumOperationCurrency operationCurrency, decimal operationValue,
            string description, string observation) {

            OperationType = operationType;
            OperationCurrency = operationCurrency;
            OperationValue = operationValue;
            Description = description;
            Observation = observation;
            OperationDate = DateTime.Now;

        }

        public void Validate()
        {
            if(String.IsNullOrEmpty(Description))
            {
                throw new ArgumentNullException();
            }
        }

    }
}
