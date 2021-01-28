using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Ticket.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

                var loggerConfiguration = new LoggerConfiguration()
                   .Enrich.FromLogContext()
                   .Enrich.WithProperty("MachineName", Environment.MachineName)
                   .Enrich.WithProperty("Environment", env)
                   .Enrich.WithProperty("ApplicationName", "TicketWeb");


                loggerConfiguration.WriteTo.Seq("http://localhost:5341");

                Log.Logger = loggerConfiguration.CreateLogger();

                Log.Information("Service Starting Up");

                CreateHostBuilder(args).Build().Run();

            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Service Failed to Start");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
       Host.CreateDefaultBuilder(args)
           .ConfigureWebHostDefaults(webBuilder =>
           {
               webBuilder.UseStartup<Startup>();
           }).UseSerilog();
    }
}
