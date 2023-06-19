using E_Ticaret.Domain.Entities;

namespace E_Ticaret.Application.Features.Queries.ProductQueries.GetAllQuery
{
    public class GetAllProductQueryResponse
    {
        public int TotalCount { get; set; }
        public object Products { get; set; }
    }
}