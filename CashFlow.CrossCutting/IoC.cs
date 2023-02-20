using CashFlow.Domain.Interfaces.Repositories;
using CashFlow.Domain.Interfaces.Services;
using CashFlow.Domain.Services;
using CashFlow.Repository.Context;
using CashFlow.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.CrossCutting
{
    public class IoC
    {
        public static void Configure(IServiceCollection service, string connectionString)
        {
            #region Registra IOC

            #region IOC Services
            service.AddScoped<IPostingEntryService, PostingEntryService>();
            #endregion

            #region IOC Repositorys SQL         
            //service.AddScoped<ICashFlowContext, CashFlowContext>();
            service.AddDbContext<CashFlowContext>(options => options.UseSqlServer(connectionString));
            service.AddScoped<IPostingEntryRepository, PostingEntryRepository>();
            #endregion

            #endregion

        }
    }
}