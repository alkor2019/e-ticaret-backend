using E_Ticaret.Application.Abstractions.Results;
using E_Ticaret.Domain.Entities;

namespace E_Ticaret.Application.Features.Queries.ProductImageQueries.GetByProductIdQuery
{
    public class GetByProductIdProductImageQueryResponse : DataResult<List<ProductImageFile>>
    {
        public GetByProductIdProductImageQueryResponse(List<ProductImageFile> data, string message, bool success) : base(data, message, success)
        {
        }
    }
}