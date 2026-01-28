
using Delivery.Core.Services;
using DeliveryProject;
using Delivery.Core;
using Delivery.Core.Respositories;
using Delivery.Service;
using Delivery.Data.Repositories;
using Delivery.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDeliverService, DeliverService>();
builder.Services.AddScoped<IDeliverRepository, DeliversRepository>();

builder.Services.AddScoped<IRecipientService, RecipientService>();
builder.Services.AddScoped<IRecipientRespository, RecipientRepository>();

builder.Services.AddScoped<IPackageService, PackageService>();
builder.Services.AddScoped<IPackagesRespository, PackagesRepository>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddDbContext<DataContext>();


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

