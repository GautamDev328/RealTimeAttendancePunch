using CRUDAPPLICATION.BLL.Repository;
using CRUDAPPLICATION.DATABASE;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<EmployeeDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DataConnection")));
////builder.Services.AddScoped<CityRepository>();
//builder.Services.AddControllers();
//builder.Services.AddScoped<CityRepository>();

var app = builder.Build();

// void ConfigureServices(IServiceCollection services)
//{
//    services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//        .AddCookie(options =>
//        {
//            options.LoginPath = "/Admin/Login";  // Update this path as needed
//        });

//    services.AddControllersWithViews();
//}


// Configure the HTTP request pipeline.


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
//app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
        //pattern: "{controller=CONSUMEAPI}/{action=Index}/{id?}");
        pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


