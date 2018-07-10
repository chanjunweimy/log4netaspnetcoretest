using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace NetCoreWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Directory.SetCurrentDirectory(exeDir);

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging((hostingContext, logging) =>
                {
                    logging.AddLog4Net();
                    logging.SetMinimumLevel(LogLevel.Debug);
                    // The ILoggingBuilder minimum level determines the
                    // the lowest possible level for logging. The log4net
                    // level then sets the level that we actually log at.
                })
                .Build();
    }
}
