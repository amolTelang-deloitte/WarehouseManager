using Microsoft.EntityFrameworkCore;
using WarehouseManagementService.Application.Interface;
using WarehouseManagementService.Application.Repository;
using WarehouseManagementService.Application.Services;
using WarehouseManagementService.Infrastructure.Persistence;
using WarehouseManagementService.Infrastructure.Repository;
using IOrderService = WarehouseManagementService.Application.Interface.IOrderService;
using OrderServices = WarehouseManagementService.Application.Services.OrderServices;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//add database
builder.Services.AddDbContext<PalletDbContext>(opt =>opt.UseSqlServer(configuration.GetConnectionString("DefaultConnectionOne"),
    b => b.MigrationsAssembly("WarehouseManagementService.API")));
builder.Services.AddDbContext<OrderDbContext>(opt =>opt.UseSqlServer(configuration.GetConnectionString("DefaultConnectionTwo"),
    b => b.MigrationsAssembly("WarehouseManagementService.API")));

builder.Services.AddScoped<IOrderService, OrderServices>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IPalletRepository, PalletRepository>();
builder.Services.AddScoped<IPalletService, PalletServices>();



builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Manager", policy => policy.RequireClaim("permissions", "private:conn"));
    options.AddPolicy("Public", policy => policy.RequireClaim("permissions", "public:conn"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
