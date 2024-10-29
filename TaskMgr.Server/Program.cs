using Microsoft.EntityFrameworkCore;
using TaskMgr.Server.Data;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;
// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();     // Config for Hosted in .Net8

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(config.GetConnectionString("DefaultConnection") );
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseWebAssemblyDebugging();    // Config for Hosted in .Net8
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();      // Config for Hosted in .Net8
app.UseStaticFiles();               // Config for Hosted in .Net8

app.UseAuthorization();

app.MapRazorPages();                    // Config for Hosted in .Net8
app.MapControllers();                   // Config for Hosted in .Net8
app.MapFallbackToFile("index.html");    // Config for Hosted in .Net8

app.Run();
