using Dosaaf.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlite(connection));
builder.Services.AddTransient<IEncryptionService, EncryptionService>();
builder.Services.AddTransient<IEmailService, EmailService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseDefaultFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{action}/{id?}",
    defaults: new { controller = "Home", action = "Index"}
    );
app.MapControllerRoute(
    name: "admin-panel",
    pattern: "AdminPanel/{action}/{id?}",
    defaults: new { controller = "AdminPanel", action = "Index" }
    );

app.Run();
