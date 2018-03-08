using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CSharp7_2.Web
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            BuildWebHost(args).Run();
            return await DoNothing();
        }

        private static async Task<int> DoNothing()
        {
            await Task.Delay(1000);
            return 0;
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
