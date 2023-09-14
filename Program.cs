using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Lingzu.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<LingzuContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LingzuContext") ?? throw new InvalidOperationException("Connection string 'LingzuContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
