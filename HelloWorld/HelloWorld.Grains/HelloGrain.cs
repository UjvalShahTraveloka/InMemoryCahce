using System;
using System.Net;
using System.Threading.Tasks;
using HelloWorld.Grains;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Configuration;
using Orleans.Hosting;

namespace SiloHost
{
    class Program
    {
        public static async Task Main(string[] args)
                 {
                     var builder = new SiloHostBuilder()
                         .UseLocalhostClustering()
                         .Configure<ClusterOptions>(options =>
                         {
                             options.ClusterId = "dev";
                             options.ServiceId = "HelloWorld";
                         })
                         .Configure<EndpointOptions>(options => options.AdvertisedIPAddress = IPAddress.Loopback)
                         .ConfigureApplicationParts(parts =>
                             parts.AddApplicationPart(typeof(HelloGrain).Assembly).WithReferences())
                         .ConfigureLogging(logging => logging.AddConsole());
         
                     var host = builder.Build();
                     await host.StartAsync();
                     
                     Console.WriteLine("Press enter to terminate !!");
                     Console.ReadKey();
         
                 }
    }
}
