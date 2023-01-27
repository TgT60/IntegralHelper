using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperAPI.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public Worker Worker { get; set; }
    }
}
