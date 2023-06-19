using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Repositories.ProductImageFiles;
using E_Ticaret.Domain.Entities;
using E_Ticaret.Persistence.Contexts;

namespace E_Ticaret.Persistence.Repositories.ProductImageFiles
{
    public class ProductImageFileReadRepository : ReadRepository<ProductImageFile>, IProductImageFileReadRepository
    {
        public ProductImageFileReadRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}