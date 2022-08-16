var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseDefaultFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{action}/{id?}",
    defaults: new { controller = "Home", action = "Index"}
    );

app.Run();
