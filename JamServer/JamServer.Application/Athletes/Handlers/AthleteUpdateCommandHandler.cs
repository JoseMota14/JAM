using JamServer.Application.Athletes.Commands;
using JamServer.Domain.Entities;
using JamServer.Domain.Interfaces;
using MediatR;

namespace JamServer.Application.Athletes.Handlers
{
    public class AthleteUpdateCommandHandler : IRequestHandler<AthleteUpdateCommand, Athlete>
    {
        public readonly IAthleteRepository _athleteRepository;
        public AthleteUpdateCommandHandler(IAthleteRepository athleteRepository)
        {
            _athleteRepository = athleteRepository ?? throw new ArgumentNullException(nameof(athleteRepository));
        }

        public async Task<Athlete> Handle(AthleteUpdateCommand request, CancellationToken cancellationToken)
        {
            var athlete = await _athleteRepository.GetById(request.Id);

            if (athlete == null)
            {
                throw new ApplicationException("Error creating athlete");
            }
            else
            {
                athlete.Update(request.Name, request.Birthday);
                return await _athleteRepository.Update(athlete);
            }
        }
    }
}
