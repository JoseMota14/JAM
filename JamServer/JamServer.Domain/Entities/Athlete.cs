using JamServer.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Domain.Entities
{
    public sealed class Athlete : Entity
    {

        public string Name { get; private set; }

        public DateTime Birthday { get; private set; }

        public ICollection<Clothes> Clothes { get;  set; }

        public Athlete(string name, DateTime birthday)
        {
            ValidateDomainName(name);
            ValidateDomainBirthday(birthday);
        }

        public Athlete(int id, string name, DateTime birthday)
        {
            DomainValidation.When(id < 0 , "Invalid id.");
            Id = id;
            ValidateDomainName(name);
            ValidateDomainBirthday(birthday);
        }

        public void Update(string name, DateTime birthday)
        {
            ValidateDomainName(name);
            ValidateDomainBirthday(birthday);
        }

        private void ValidateDomainName(string name)
        {
            DomainValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required");
            DomainValidation.When(name.Length < 2, "Invalid name. Can't be less than 2 chars");

            Name = name;
        }

        private void ValidateDomainBirthday(DateTime birthday)
        {
            DomainValidation.When(DateTime.UtcNow > birthday, "Invalid birthday");

            Birthday = birthday;
        }
    }
}
