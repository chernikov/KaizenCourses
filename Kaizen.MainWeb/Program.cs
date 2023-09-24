using Kaizen.Core;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


var connectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<KaizenDbContext>(opt => 
    opt.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


var app = builder.Build();

Database.Migrate(app);
// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
