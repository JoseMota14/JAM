using JamServer.Domain.Entities;
using MediatR;

namespace JamServer.Application.Athletes.Commands
{
    public class AthleteRemoveCommand: IRequest<Athlete>
    {
        public int Id { get; set; }
        public AthleteRemoveCommand(int id)
        {
            Id= id;
        }
    }
}
