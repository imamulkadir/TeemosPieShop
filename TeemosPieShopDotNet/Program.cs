using Microsoft.EntityFrameworkCore;
using TeemosPieShopDotNet.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TeemosPieShopDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:TeemosPieShopDbContextConnection"]);
});


var app = builder.Build();

app.UseStaticFiles();

if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

DbInitializer.Seed(app);

app.Run();
