using FluentAssertions;
using JamServer.Domain.Entities;
using JamServer.Domain.Validation;
using System;
using Xunit;

namespace JamServer.Domain.Test
{
    public class AthletesUnitTest1
    {
        [Fact(DisplayName = "Valide params")]
        public void CreateAthlete_WithValid_ValidState()
        {
            Action action = () => new Athlete("teste1", DateTime.Now);
            action.Should().NotThrow<DomainValidation>();
        }

        [Fact(DisplayName = "Invalide params")]
        public void CreateAthlete_WithInvalid_InvalidState()
        {
            Action action = () => new Athlete("1", DateTime.Now);
            action.Should()
                .Throw<DomainValidation>()
                .WithMessage("Invalid name. Can't be less than 2 chars");
        }
    }
}