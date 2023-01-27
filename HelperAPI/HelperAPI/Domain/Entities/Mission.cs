using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperAPI.Domain.Entities
{
    public class Task
    {
        public ICollection<Worker> Workers { get; set; }
        public ICollection<ServiceItem> serviceItems { get; set; }
    }
}
