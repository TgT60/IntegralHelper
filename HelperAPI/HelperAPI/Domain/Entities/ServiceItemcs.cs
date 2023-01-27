using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperAPI.Domain.Entities
{
    public class ServiceItemcs
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string ShortDiscription { get; set; }

        public string LongDiscripton { get; set; }
    }
}
