using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperAPI.Domain.Entities
{
    public class Worker
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public string SureName { get; set; }
        
        public string PersonImg { get; set; }

        public ICollection<Equipment> Equipment { get; set; }

    }
}
