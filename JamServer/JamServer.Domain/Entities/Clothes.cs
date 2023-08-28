using JamServer.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Domain.Entities
{
    public sealed class Clothes : Entity
    {

        public string Name { get; private set; }

        public string Description { get; private set; }

        public string Size { get; private set; }

        public int AtlheteId { get; set; }
        public Athlete Athlete { get; set; }

        public Clothes(string name, string description, string size)
        {
            ValidateDomain(name, description,size);
        }

        public Clothes(int id, string name, string description, string size)
        {
            DomainValidation.When(id < 0, "Invalid id.");
            Id = id;
            ValidateDomain(name, description, size);
        }

        public void Update(string name, string description, string size, int athleteId)
        {
            ValidateDomain(name, description, size);
            AtlheteId = athleteId;
        }


        private void ValidateDomain(string name, string description, string size)
        {
            DomainValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required");
            DomainValidation.When(name.Length < 2, "Invalid name. Can't be less than 2 chars");
            DomainValidation.When(string.IsNullOrEmpty(description), "Invalid description. Description is required");
            DomainValidation.When(string.IsNullOrEmpty(size), "Invalid size. Size is required");
            Name = name;
            Description = description;
            Size = size;
        }

    }
}
