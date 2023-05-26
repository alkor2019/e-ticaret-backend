using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Domain.Entities.Common;
namespace E_Ticaret.Domain.Entities
{
    public class Order:BaseEntity
    {
        public int CustomerId { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

         public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }
    }
}