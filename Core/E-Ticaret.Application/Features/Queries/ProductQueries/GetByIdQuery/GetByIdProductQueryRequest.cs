using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Repositories.Products;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace E_Ticaret.Application.Features.Queries.ProductQueries.GetByIdQuery
{
    public class GetByIdProductQueryRequest:IRequest<GetByIdProductQueryResponse>
    {
        public int Id { get; set; }
    }
    public class GetByIdProductQueryResponse
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public short UnitsInStock { get; set; }
        
    }
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        private readonly IProductReadRepository _productReadRepository;

        public GetByIdProductQueryHandler(IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = await _productReadRepository.GetByIdAsync(request.Id);
          
            return new(){
                Id = product.Id,
                CategoryId = product.CategoryId,
                Name = product.Name,
                Price = product.Price,
                UnitsInStock = product.UnitsInStock
            };
        }
    }
}