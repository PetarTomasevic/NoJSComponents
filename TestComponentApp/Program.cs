using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using C3Logging.DatabaseLogging;
using C3Logging.FileLogging;

namespace TestComponentApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            //.ConfigureLogging(x => x.AddApplicationInsightLogging())
            .ConfigureLogging(x =>
            x.AddEventLog()
            .AddDebug()
            .AddConsole()
            .AddDatabaseLogging("Data Source=DESKTOP-0O9V0C7;Initial Catalog=IdentityShemaDatabase;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False")
            .AddFileLogging(Directory.GetCurrentDirectory() + "/App_Data/")
            .AddFilter<DatabaseLoggerProvider>(logLevel => logLevel == LogLevel.Error)
            )

                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}