using Microsoft.EntityFrameworkCore;
using Business;
using DataAccess;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();


builder.Services.AddDbContext<DataAccess.RentACarContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);


builder.Services.AddScoped<IBrandService, BrandManager>();


builder.Services.AddScoped<IBrandRepository, EfBrandRepository>();


builder.Services.AddScoped<ICarRepository, EfCarRepository>();




builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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