using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Domain.Validation
{
    public class DomainValidation : Exception
    {
        public DomainValidation(string error) : base(error) { }

        public static void When(bool condition, string error)
        {
            if (condition)
            {
                throw new DomainValidation(error);
            }
        }
    }
}
