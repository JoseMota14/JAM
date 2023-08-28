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
    public class AthleteCreateCommandHandler : IRequestHandler<AthleteCreateCommand, Athlete>
    {
        public readonly IAthleteRepository _athleteRepository;
        public AthleteCreateCommandHandler(IAthleteRepository athleteRepository)
        {
            _athleteRepository = athleteRepository ?? throw new ArgumentNullException(nameof(athleteRepository)); ;
        }

        public async Task<Athlete> Handle(AthleteCreateCommand request, CancellationToken cancellationToken)
        {
            var athlete = new Athlete(request.Name, request.Birthday);

            if (athlete == null)
            {
                throw new ApplicationException("Error creating athlete");
            }
            else
            {
                return await _athleteRepository.Create(athlete);
            }
        }
    }
}
