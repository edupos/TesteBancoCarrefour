using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CashFlow.Repository.Context
{
    public class CashFlowContext : DbContext
    {
        public CashFlowContext()
        {

        }
        public CashFlowContext(DbContextOptions<CashFlowContext> options)
            : base(options)
        { }
        public DbSet<PostingEntry>? PostingEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostingEntry>()
                .HasKey(o => new { o.Id });
            modelBuilder.Entity<PostingEntry>()
                .Property(o => o.OperationType).IsRequired();
            modelBuilder.Entity<PostingEntry>()
                .Property(o => o.OperationCurrency).IsRequired();
            modelBuilder.Entity<PostingEntry>()
                .Property(o => o.OperationValue).IsRequired();
            modelBuilder.Entity<PostingEntry>()
                .Property(o => o.Description).IsRequired();
            modelBuilder.Entity<PostingEntry>()
                .Property(o => o.Observation).IsRequired();
            modelBuilder.Entity<PostingEntry>()
                .Property(o => o.OperationDate).IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
