using E_Ticaret.Application.Repositories.Products;
using MediatR;

namespace E_Ticaret.Application.Features.Commands.ProductCommands.UpdateCommand
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        public UpdateProductCommandHandler(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await _productReadRepository.GetByIdAsync(request.Id);
            product.CategoryId = request.CategoryId;
            product.Name = request.Name;
            product.Price = request.Price;
            product.UnitsInStock = request.UnitsInStock;
            await _productWriteRepository.SaveAsync();
            return new(){
                    Message = "Ürün Güncellendi",
                    Success = true
            };
        }
    }

}