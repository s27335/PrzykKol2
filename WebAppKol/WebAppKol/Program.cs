using Microsoft.EntityFrameworkCore;
using WebAppKol.Models;

public class Program
{

    public static void Main(string[] args)
    {
        //Komendy
        //dotnet new tool-manifest
        //dotnet tool install dotnet-ef --version 8.0.0
        
        //dotnet ef migrations add ______
        //dotnet ef database update
        var builder = WebApplication.CreateBuilder(args);

        // Registering services
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddControllers(); 
        //builder.Services.AddScoped<>();
       

        builder.Services.AddDbContext<KolDbContext>(
            opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
        
        var app = builder.Build();
        

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.MapControllers();

        app.Run();
    }
}