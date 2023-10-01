using Kaizen.Core;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


var connectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<KaizenDbContext>(opt => 
    opt.UseSqlServer(connectionString));

var key = Encoding.ASCII.GetBytes(builder.Configuration["JwtSecret"]!);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;

        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
builder.Services.AddAuthorization();


var app = builder.Build();

Database.Migrate(app);
// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
