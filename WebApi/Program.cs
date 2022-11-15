using Database.DBcontext;
using Database.Interfaces;
using Database.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//public void ConfigureServices(IServiceCollection services)
//{
builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "API",
            Version = "v1",
            Description = "An API to perform CRUD operations",
            TermsOfService = new Uri("https://example.com/terms"),

            License = new OpenApiLicense
            {
                Name = "License",
                //Url = new Uri("https://example.com/license"),
            }
        });

        
    });

        builder.Services.AddDbContext<Sqlserver>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));
        builder.Services.AddScoped<ICustomer, CustomerRepos>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    
