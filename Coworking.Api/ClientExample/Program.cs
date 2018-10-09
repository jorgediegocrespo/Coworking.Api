using IdentityModel.Client;
using System;
using System.Threading.Tasks;

namespace ClientExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        public static async Task MainAsync()
        {
            var discoveryClient = await DiscoveryClient.GetAsync("http://localhost:5000/");
            if (discoveryClient.IsError)
            {
                Console.WriteLine(discoveryClient.Error);
                return;
            }

            var tokenClient = new TokenClient(discoveryClient.TokenEndpoint, "client", "511536EF-F270-4058-80CA-1C89C192F69A");
            var response = await tokenClient.RequestClientCredentialsAsync("api1");

            if (response.IsError)
            {
                Console.WriteLine(response.Error);
                return;
            }

            Console.WriteLine(response.Json);
        }
    }
}
