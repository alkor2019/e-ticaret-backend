using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Domain.Entities.Common;
namespace E_Ticaret.Domain.Entities
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public short UnitsInStock { get; set; }
        
        public Category Category { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}