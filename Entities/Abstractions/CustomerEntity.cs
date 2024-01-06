using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstractions
{
    public class CustomerEntity
    {
        public Guid CustomerId { get; set; }

        public CustomerEntity()
        {
            CustomerId = Guid.NewGuid();
        }
    }
}
