using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Domain.Entities;

namespace E_Ticaret.Application.ViewModels.Products
{
    public class VM_Product_List
    {
        public List<Product> Products { get; set; }
        public int TotalCount { get; set; }
        
        
        
    }
}