using NcDonalds.Extens�o;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace NcDonalds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().CreateAdminRole().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    }
}
