using Fido2NetLib;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Enable static files (wwwroot), routing, and MVC
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

// Default route: maps / to HomeController.Index()
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


/*
 * builder.Services.AddSingleton<Fido2>(sp => {
    var config = builder.Configuration.GetSection("Fido2");
    return new Fido2(new Fido2Configuration
    {
        ServerDomain = config["ServerDomain"],
        Origin = config["Origin"],
        ServerName = config["ServerName"]
    });
});
*/