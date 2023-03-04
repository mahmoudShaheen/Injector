
using Injector;
using System.Diagnostics;
using TestAppServices;

namespace TestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddInjector(
                conf =>
                {
                    conf.RegisterServices = true;
                    conf.RegisterHostedServices = false;
                    conf.RegistrationStrategy = Injector.Config.RegistrationStrategy.IgnoreIssues;
                })
                .RegisterModule(typeof(WeatherForecast))
                .RegisterModule(typeof(TestAppServicesModule));

            foreach (var item in builder.Services)
            {
                Debug.WriteLine("\r\n\r\n" + item + "\r\n\r\n");
            }

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}