using E_Ticaret.Application.Abstractions.Results;
using E_Ticaret.Application.ViewModels.Products;
using E_Ticaret.Domain.Entities;

namespace E_Ticaret.Application.Features.Queries.ProductQueries.GetAllQuery
{
    public class GetAllProductQueryResponse : DataResult<VM_Product_List>
    {
        public GetAllProductQueryResponse(VM_Product_List data, string message, bool success) : base(data, message, success)
        {
        }
    }
}