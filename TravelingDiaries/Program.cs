using Microsoft.EntityFrameworkCore;
using TravelingDiaries.Controllers;
using TravelingDiaries.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//services for the DI of repository
builder.Services.AddScoped<IPlaceRepository, PlaceRepository>();

//shopping cart constructor
builder.Services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));


//AppDBContext connetion
string connString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connString));


//adding httpscontext and seesion service
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();
//

var app = builder.Build();
//





// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

//using sessions
app.UseSession();


app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
