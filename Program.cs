using WebApplication2.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IFigureGenerator, FigureGenerator>();
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
