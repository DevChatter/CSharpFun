using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CSharp7.Web
{
    public class Program
    {
        public static int Main(string[] args)
        {
            BuildWebHost(args).Run();
            return DoNothing().GetAwaiter().GetResult();
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
