using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.DATABASE;


//using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Options;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<EmployeeDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DataConnection")));



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle




builder.Services.AddScoped<EmployeeProfileRepository>();
builder.Services.AddScoped<StateRepository>();

builder.Services.AddScoped<CustomerPricesRespository>();
builder.Services.AddScoped<CountryRepository>();
builder.Services.AddScoped<CityRepository>();
builder.Services.AddScoped<DepartmentRepository>();
builder.Services.AddScoped<DesignationRepository>();
builder.Services.AddScoped<EmployeeQueryRepository>();
builder.Services.AddScoped<GenderRepository>();
builder.Services.AddScoped<RELATIONREPOSITORY>();
builder.Services.AddScoped<ROLEWISEREPSITORY>();
builder.Services.AddScoped<RolewiseonlyemployeeRepository>();
builder.Services.AddScoped<UserTrailRepository>();
builder.Services.AddScoped<CustomerPaymentRepository>();


builder.Services.AddHttpContextAccessor();
//builder.Services.AddControllersWithViews();

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
//app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
