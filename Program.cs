using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;
using Hangfire;
using Hangfire.SqlServer;

namespace calendarWebApp
{
    public class Program
    {
        public static void InitializeHangFire()
        {
            var sqlStorage = new SqlServerStorage(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            var options = new BackgroundJobServerOptions
            {
                ServerName = "Test Server"
            };
            JobStorage.Current = sqlStorage;
        }
        public static void Main(string[] args)
        {
            InitializeHangFire();
            CreateHostBuilder(args).Build().Run();
        }

        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
