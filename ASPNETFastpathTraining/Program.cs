using ASPNETFastpathTraining.Klassen;
using ASPNETFastpathTraining.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSession(o=>o.Cookie.HttpOnly=true);
builder.Services.AddRazorPages();
builder.Services.AddSingleton<Zaehler>();
builder.Services.AddHttpClient();
builder.Services.AddControllers();
builder.Services.AddDbContext<KundenContext>(o=>o.UseSqlServer(
    builder.Configuration.GetConnectionString("Kunden")
    )
    );
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthorization();
app.MapRazorPages();
app.MapControllers();

app.Run();
