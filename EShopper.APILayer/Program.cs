using Autofac;
using Autofac.Extensions.DependencyInjection;
using EShopper.BusinessLayer.Abstract;
using EShopper.BusinessLayer.Concrete;
using EShopper.BusinessLayer.DependencyResolves.Autofac;
using EShopper.DataAccessLayer.Abstract;
using EShopper.DataAccessLayer.Concrete;
using EShopper.DataAccessLayer.Context;
using EShopper.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Serilog;
var builder = WebApplication.CreateBuilder(args);
//Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacManager());
});

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<EShopperDbContext>();
builder.Services.AddDbContext<EShopperDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration["ConnectionStrings:SqlCon"]);
});
Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().
    MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Information).
    Enrich.FromLogContext().
    WriteTo.Console().
    WriteTo.MSSqlServer(
    connectionString: builder.Configuration["ConnectionStrings:SqlCon"], tableName: "Logs", autoCreateSqlTable: true)
   .CreateLogger();
builder.Services.AddScoped(typeof(RepositoryDal<>), typeof(RepositoryDal<>));
builder.Services.AddScoped<IBrandService, BrandManager>();
 builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
    .UseSerilog();
try
{
    Log.Information("Starting up");
   
    CreateHostBuilder(args).Build();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application start-up failed");
   

}
finally
{
    Log.CloseAndFlush();
}

var app = builder.Build();



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
