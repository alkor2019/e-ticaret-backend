using E_Ticaret.Application.Repositories.Products;
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
             var products = data.Skip(request.Page * request.Size).Take(request.Size)
             .Select(p => new{
                p.Id,
                p.CategoryId,
                p.Name,
                p.Price,
                p.UnitsInStock,
                p.CreatedDate,
                p.UpdatedDate
             });
             int totalCount = data.Count();
             return new (){
                 TotalCount = totalCount,
                 Products = products
             };
        }
    }
}