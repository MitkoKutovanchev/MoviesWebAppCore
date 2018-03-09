﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Data.DB;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace moviesWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();


        //public static IWebHost BuildWebHost(string[] args) =>
        //  new WebHostBuilder()
        //      .UseKestrel()
        //      .UseContentRoot(Directory.GetCurrentDirectory())
        //      .UseIISIntegration()
        //      .UseStartup<Startup>()
        //      .Build();


    }
}
