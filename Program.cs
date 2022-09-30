using Microsoft.EntityFrameworkCore;
using SchedulerProj.Data;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container
var connectionStringMysql = builder.Configuration.GetConnectionString("ConnectionMysql");
builder.Services.AddDbContext<Context>(options => options.UseMySql(
        connectionStringMysql,
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql")
    )
);

builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();