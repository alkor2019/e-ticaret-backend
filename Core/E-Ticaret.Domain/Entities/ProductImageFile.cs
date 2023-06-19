using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.Domain.Entities
{
    public class ProductImageFile : FileEntity
    {
       
        public ICollection<Product> Products { get; set; }
    }
}