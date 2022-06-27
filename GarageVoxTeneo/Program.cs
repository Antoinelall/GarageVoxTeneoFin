

using GarageVoxTeneo.BLL.Services;
using GarageVoxTeneo.DAL.Interfaces;
using GarageVoxTeneo.DAL.Repositories;
using System.Data.SqlClient;
using Tools.Connections;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Config Injection
// - Tools
builder.Services.AddTransient<Connection>((service) =>
{
    return new Connection(
        SqlClientFactory.Instance,
        builder.Configuration.GetConnectionString("Default")
    );
});


builder.Services.AddTransient<IGaragesRepository, GaragesRepositories>();
builder.Services.AddTransient<ICarsRepository, CarsRepositories>();

// - BLL
builder.Services.AddTransient<GaragesService>();
builder.Services.AddTransient<CarsService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
