using Autofac;
using Autofac.Extensions.DependencyInjection;
using CBR_Exchange_Rate_App.Data.ApiClient;
using CBR_Exchange_Rate_App.Data.ApiClient.Interfaces;
using CBR_Exchange_Rate_App.Data.Currencies.Repositories.CBR;
using CBR_Exchange_Rate_App.Domain.Services.CBR_Rate;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);
var appConfig = builder.Configuration;

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterType<CbrApiClient>().As<IApiClient>().WithParameter("apiUrl", appConfig["APIs:CbrApiUrl"]);
        builder.RegisterType<CbrRepository>().As<ICbrRepository>();
        builder.RegisterType<CbrCurrenciesService>().As<ICbrCurrenciesService>();
    });
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
