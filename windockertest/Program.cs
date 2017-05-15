using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace windockertest
{
    public class Program
    {

        public static void Main(string[] args)
        {

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }

    // Used to inject in the MVC framework
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }

    // Example controller
    public class TestController : Controller
    {
        [HttpGet("/")]
        public object Index()
        {
            return "Docker is running there => COMPUTERNAME: " + Environment.GetEnvironmentVariable("COMPUTERNAME");
        }
    }
}
