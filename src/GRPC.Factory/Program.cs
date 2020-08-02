using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace GRPC.Factory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            var guitarChannel = GrpcChannel.ForAddress("http://localhost:5000");
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
