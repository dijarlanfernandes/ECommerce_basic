
using Ecommerce.Services.Web.IServices;
using Ecommerce.Services.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IServiceProduct, ServiceProduct>();
builder.Services.AddLogging();
var baseurl = "https://localhost:7262/";
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(baseurl)
});
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
