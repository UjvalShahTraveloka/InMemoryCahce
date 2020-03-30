using System;
using System.Threading.Tasks;
using HelloWorld.Interfaces;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Configuration;

namespace OrleansClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new ClientBuilder()
                .UseLocalhostClustering()
                .Configure<ClusterOptions>(options =>
                {
                    options.ClusterId = "dev";
                    options.ServiceId = "HelloWorld";
                })
                .ConfigureLogging(logging => logging.AddConsole())
                .Build();

            await client.Connect();
            Console.WriteLine("Client successfully connect to silo host");
  
            await DoClientWork(client);
            Console.ReadKey();

        }

        private static async Task DoClientWork(IClusterClient client)
        {
            // example of calling grains from the initialized client
            var friend = client.GetGrain<IHello>(0);
            var response = await friend.SayHello("Good morning, my friend!");
            Console.WriteLine("\n\n{0}\n\n", response);
        }

    }
}
