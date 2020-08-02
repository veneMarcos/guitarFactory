using System.Threading.Tasks;
using Grpc.Core;

namespace GRPC.Guitar
{
    public class GuitarService : Guitar.GuitarBase
    {
        public override Task<GuitarReply> MakeGuitar(GuitarRequest request, ServerCallContext context)
        {
            var guitar = Domain.Guitar.MakeGuitar((Domain.Color)request.GuitarColor, request.StringQuantity, (Domain.Model)request.GuitarModel);

            return Task.FromResult(new GuitarReply { GuitarID = guitar.Id.ToString() });
        }
    }
}
