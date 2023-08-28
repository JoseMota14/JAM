using JamServer.Domain.Entities;
using MediatR;

namespace JamServer.Application.Athletes.Queries
{
    public class GetAthleteByIdQuery : IRequest<Athlete>
    {
        public int Id { get; set; }
        public GetAthleteByIdQuery(int id)
        {
            Id = id;
        }
    }
}
