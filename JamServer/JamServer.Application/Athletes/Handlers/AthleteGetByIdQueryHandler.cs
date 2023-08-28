using JamServer.Application.Athletes.Commands;
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
    internal class AthleteGetByIdQueryHandler : IRequestHandler<GetAthleteByIdQuery, Athlete>
    {
        public readonly IAthleteRepository _athleteRepository;
        public AthleteGetByIdQueryHandler(IAthleteRepository athleteRepository)
        {
            _athleteRepository = athleteRepository ?? throw new ArgumentNullException(nameof(athleteRepository)); ;
        }

        public async Task<Athlete> Handle(GetAthleteByIdQuery request, CancellationToken cancellationToken)
        {

            return await _athleteRepository.GetById(request.Id);
        }
    }
}
