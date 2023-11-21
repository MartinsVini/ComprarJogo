
using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository;
using ComprarJogo.Repository.Interfaces;
using ComprarJogo.Services;
using Microsoft.EntityFrameworkCore;

namespace ComprarJogo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<CompraDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("Data Source = localhost; Persist Security Info = True; User ID = padrao; Password = 123456;TrustServerCertificate=True;")));

            
            builder.Services.AddScoped<ClienteService>();
            builder.Services.AddScoped<CompraService>();
            builder.Services.AddTransient<IClienteDAO, ClienteDAO>();
            builder.Services.AddTransient<ICompraDAO, CompraDAO>();
            builder.Services.AddTransient<IJogoDAO, JogoDAO>();
            builder.Services.AddTransient<IPagamentoDAO, PagamentoDAO>();


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
        }
    }
}