using E_Ticaret.Application.Repositories.Products;
using MediatR;

namespace E_Ticaret.Application.Features.Commands.ProductCommands.RemoveCommand
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommandRequest, RemoveProductCommandResponse>
    {
        private readonly IProductWriteRepository _productWriteRepository;

        public RemoveProductCommandHandler(IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
        }

        public async Task<RemoveProductCommandResponse> Handle(RemoveProductCommandRequest request, CancellationToken cancellationToken)
        {
           var result =  await _productWriteRepository.RemoveAsync(request.Id);
            await _productWriteRepository.SaveAsync();
            return result ? new("Ürün başrıyla silindi", true) : new("Ürün silinirken bir hata oluştu", false);
        }
    }
}