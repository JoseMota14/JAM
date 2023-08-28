using JamServer.Domain.Entities;
using MediatR;

namespace JamServer.Application.Athletes.Queries
{
    public class GetAthletesQuery : IRequest<IEnumerable<Athlete>>
    {
        
    }
}
