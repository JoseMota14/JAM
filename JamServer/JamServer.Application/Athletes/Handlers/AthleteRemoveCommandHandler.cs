using JamServer.Application.Athletes.Commands;
using JamServer.Domain.Entities;
using JamServer.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Application.Athletes.Handlers
{
    public class AthleteRemoveCommandHandler : IRequestHandler<AthleteRemoveCommand, Athlete>
    {
        public readonly IAthleteRepository _athleteRepository;
        public AthleteRemoveCommandHandler(IAthleteRepository athleteRepository)
        {
            _athleteRepository = athleteRepository ?? throw new ArgumentNullException(nameof(athleteRepository));
        }

        public async Task<Athlete> Handle(AthleteRemoveCommand request, CancellationToken cancellationToken)
        {
            var athlete = await _athleteRepository.GetById(request.Id);

            if (athlete == null)
            {
                throw new ApplicationException("Error creating athlete");
            }
            else
            {
                return await _athleteRepository.Remove(athlete);
            }
        }
    }
}
