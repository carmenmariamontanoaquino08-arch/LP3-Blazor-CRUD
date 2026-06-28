using LP3.Blazor.Application.Services;
using LP3.Blazor.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using P3.Blazor.Data;

public partial class Program
{
    private static void Main(string[] args)
    {
        // Add services to the container
        IServiceCollection serviceCollection1 =
         builder.Services.AddDbContext<ApplicationDbContext>(options =>
           options.UseSqlite(connectionString));

        var builder = WebApplication.CreateBuilder(args);
       var connectionString = builder?.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
    
        var services = builder.Services.AddScoped<IEstudianteService, EstudianteService>();
    ℹ️ Explicación:
                    
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        IServiceCollection serviceCollection = builder.Services.AddSingleton<WeatherForecastService>();


        var app = builder.Build();

        // Configure the HTTP request pipeline
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
    }


};