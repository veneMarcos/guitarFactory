using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace GRPC.Factory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var guitarChannel = GrpcChannel.ForAddress("https://localhost:5001");
            var guitarClient = new Guitar.Guitar.GuitarClient(guitarChannel);


            while(true)
            {
                var guitar = await guitarClient.MakeGuitarAsync(new Guitar.GuitarRequest { GuitarColor = Guitar.GuitarRequest.Types.Color.Green, StringQuantity = 6, GuitarModel = Guitar.GuitarRequest.Types.Model.Stratocaster });

                Console.WriteLine($"Guitar {guitar} is factored");

                Console.ReadKey();
            }
        }
    }
}
