using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Domain.Entities.Common;
namespace E_Ticaret.Domain.Entities
{
    public class Customer:BaseEntity
    {
        public string FullName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}