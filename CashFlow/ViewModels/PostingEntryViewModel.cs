using CashFlow.Domain.Enum;

namespace CashFlow.ViewModels
{
    public class PostingEntryViewModel
    {
        public EnumOperationType OperationType { get; set; }
        public EnumOperationCurrency OperationCurrency { get; set; }
        public decimal OperationValue { get; set; }
        public string? Description { get; set; }
        public string? Observation { get; set; }
        public DateTime OperationDate { get; }
        public int Id { get; }
    }
}
