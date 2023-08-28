using JamServer.Domain.Entities;
using MediatR;

namespace JamServer.Application.Athletes.Commands
{
    public abstract class AthleteCommand : IRequest<Athlete>
    {
        public string Name { get; private set; }
        public DateTime Birthday { get; private set; }
    }
}
