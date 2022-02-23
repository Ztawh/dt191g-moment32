using dt191g_moment32.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CollectionContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultDbString"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "cd",
    pattern: "{controller=Cd}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "artist",
    pattern: "{controller=Artist}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "loan",
    pattern: "{controller=Loan}/{action=Index}/{id?}");

app.Run();