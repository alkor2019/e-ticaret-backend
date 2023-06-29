using E_Ticaret.Application.Repositories.Products;
using E_Ticaret.Application.ViewModels.Products;
using E_Ticaret.Domain.Entities;
using MediatR;

namespace E_Ticaret.Application.Features.Queries.ProductQueries.GetAllQuery
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
    {
        private readonly IProductReadRepository _productReadRepository;

        public GetAllProductQueryHandler(IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var data = _productReadRepository.GetAll();
            VM_Product_List result = new();
             result.Products = data.Skip(request.Page * request.Size).Take(request.Size)
             .Select(p => new Product(){
                Id = p.Id,
                CategoryId = p.CategoryId,
                Name = p.Name,
                Price = p.Price,
                UnitsInStock = p.UnitsInStock,
                CreatedDate = p.CreatedDate,
                UpdatedDate = p.UpdatedDate
             }).ToList();
              result.TotalCount = data.Count();
             return new (result, "Ürünler listendi", true);
        }
    }
}