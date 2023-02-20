using AutoMapper;
using CashFlow.CrossCutting;
using CashFlow.Domain.Entities;
using CashFlow.Domain.Interfaces.Services;
using CashFlow.Mapper;
using CashFlow.ViewModels;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

//Dependency Injection
var connectionString = configuration.GetConnectionString("CashFlowConnectionString");
IoC.Configure(builder.Services, connectionString);

//Mapper
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new PostingEntryProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);


//DBCOntext
//builder.Services.AddDbContext<CashFlowContext>(o => o.UseSqlServer(connectionString));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapPost("/PostingEntry", (PostingEntryViewModel model) =>
{
    using (var serviceScope = app.Services.CreateScope())
    {

        var _mappedPostingEntry = mapper.Map<PostingEntry>(model);
        _mappedPostingEntry.Validate();

        var services = serviceScope.ServiceProvider;

        var postingEntryService = services.GetRequiredService<IPostingEntryService>();
        return postingEntryService.Add(_mappedPostingEntry).Result;
    }
}).WithName("PostPostingEntry");

app.MapGet("/MonthlyConsolidatedReport", () =>
{
    using (var serviceScope = app.Services.CreateScope())
    {

        var services = serviceScope.ServiceProvider;

        var postingEntryService = services.GetRequiredService<IPostingEntryService>();
        return postingEntryService.GetMonthlyConsolidatedReport();
    }
}).WithName("GetMonthlyConsolidatedReport");


app.Run();
