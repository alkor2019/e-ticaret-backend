using E_Ticaret.Application.Repositories.Products;
using E_Ticaret.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace E_Ticaret.Application.Features.Queries.ProductImageQueries.GetByProductIdQuery
{
    public class GetByProductIdProductImageQueryHandler : IRequestHandler<GetByProductIdProductImageQueryRequest, GetByProductIdProductImageQueryResponse>
    {
            private readonly IProductReadRepository _productReadRepository;
            private readonly IProductWriteRepository _productWriteRepository;

        public GetByProductIdProductImageQueryHandler(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        public async Task<GetByProductIdProductImageQueryResponse> Handle(GetByProductIdProductImageQueryRequest request, CancellationToken cancellationToken)
            {
                        Product? product = await _productReadRepository.Table.Include(p => p.ProductImageFiles)
                        .FirstOrDefaultAsync(x => x.Id == request.Id);

                        var result = product.ProductImageFiles.Select(x => new ProductImageFile() {
                        Id= x.Id,
                        Path = x.Path,
                        FileName = x.FileName
                        }).ToList();
                        
                        return  new(result, "Ürün resimleri listelendi", true);
                    
            }
    }
}