using JamServer.Application.Athletes.Queries;
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
    internal class AthletesGetQueryHandler : IRequestHandler<GetAthletesQuery, IEnumerable<Athlete>>
    {
        public readonly IAthleteRepository _athleteRepository;
        public AthletesGetQueryHandler(IAthleteRepository athleteRepository)
        {
            _athleteRepository = athleteRepository ?? throw new ArgumentNullException(nameof(athleteRepository)); ;
        }

        public async Task<IEnumerable<Athlete>> Handle(GetAthletesQuery request, CancellationToken cancellationToken)
        {
            return await _athleteRepository.GetAthletes();
        }
    }
}
