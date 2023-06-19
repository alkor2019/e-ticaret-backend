using E_Ticaret.Application.Repositories.ProductImageFiles;
using E_Ticaret.Domain.Entities;
using E_Ticaret.Persistence.Contexts;

namespace E_Ticaret.Persistence.Repositories.ProductImageFiles
{
    public class ProductImageFileWriteRepository : WriteRepository<ProductImageFile>, IProductImageFileWriteRepository
    {
        public ProductImageFileWriteRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}