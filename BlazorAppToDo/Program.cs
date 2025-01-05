using BlazorAppToDo.Components;
using BlazorAppToDo.Data;
using BlazorAppToDo.GameModels;
using BlazorAppToDo.Interfaces;
using BlazorAppToDo.Repositories;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace BlazorAppToDo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Конфигурация Serilog
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Configuration) // Чтение настроек из appsettings.json
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.File("Logs/log-.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            // Заменяем стандартный логгер на Serilog
            builder.Host.UseSerilog();

            // Добавление DbContext с базой в памяти
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseInMemoryDatabase("TestDb"));

            // Регистрация репозитория
            builder.Services.AddScoped<IToDoRepository, ToDoRepository>();

            // Регистрация класса ChessBoard в DI-контейнере
            builder.Services.AddTransient<ChessBoard>();

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();


            // Инициализация тестовых данных
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                SeedData.Initialize(dbContext);
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
