using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ProyectWaterUi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
var ClientHandler = new HttpClientHandler();
ClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>true;
builder.Services.AddSingleton(new HttpClient(ClientHandler)
{
    BaseAddress = new Uri("https://localhost:5001")
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
